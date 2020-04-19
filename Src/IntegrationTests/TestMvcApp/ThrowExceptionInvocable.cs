using System;
using System.Threading.Tasks;
using Coravel.Invocable;

namespace TestMvcApp
{
    public class ThrowExceptionInvocable : IInvocable
    {
        public Task Invoke()
        {
            throw new NotImplementedException();
        }
    }
}