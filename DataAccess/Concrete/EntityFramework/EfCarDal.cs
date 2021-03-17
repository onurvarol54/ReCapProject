using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (var context = new CarRentalContext())
            {
                var result = from cr in filter is null ? context.Cars : context.Cars.Where(filter)
                             join br in context.Brands
                             on cr.BrandId equals br.Id
                             join clr in context.Colors
                             on cr.ColorId equals clr.Id
                             select new CarDetailDto
                             {
                                 Id = cr.Id,
                                 BrandName = br.BrandName,
                                 ColorName = clr.ColorName,
                                 DailyPrice = cr.DailyPrice,
                                 Descriptions = cr.Descriptions,
                                 ModelYear = cr.ModelYear,
                                 CarImages = cr.CarImages


                             };

                return result.ToList();
            }
        }
    }
       
}

