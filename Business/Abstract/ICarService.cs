using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> Get(int id);

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int id);
        IDataResult<CarDetailDto> GetCarDetailsByCarId(int id);
        IResult TransactionalOperation(Car car);


    }
}
