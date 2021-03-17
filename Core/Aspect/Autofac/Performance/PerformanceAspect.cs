using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Core.Utilities.SendMail;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using Microsoft.Extensions.Options;

namespace Core.Aspect.Autofac.Performance
{
    public class PerformanceAspect : MethodInterception
    {
        private int _interval;
        private Stopwatch _stopwatch;

        public PerformanceAspect(int interval)
        {
            _interval = interval;
            _stopwatch = ServiceTool.ServiceProvider.GetService<Stopwatch>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            _stopwatch.Start();
        }

        protected override void OnAfter(IInvocation invocation)
        {

            if (_stopwatch.Elapsed.TotalSeconds > _interval)
            {
                //SendMail sendMail = new SendMail();
                //SendMailOptions sendMailOptions = new SendMailOptions
                //{
                //    Sender = _sendMailOptions.Sender,
                //    Password = _sendMailOptions.Password,
                //    Alias = _sendMailOptions.Alias,
                //    MailHost = _sendMailOptions.MailHost,
                //    MailPort = _sendMailOptions.MailPort,
                //    ToAdd = _sendMailOptions.ToAdd
                //};

                //sendMail.Send(sendMailOptions, $"Performance : {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name}-->{_stopwatch.Elapsed.TotalSeconds}");
                Debug.WriteLine($"Performance : {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name}-->{_stopwatch.Elapsed.TotalSeconds}");
            }
            _stopwatch.Reset();
        }
    }
}
