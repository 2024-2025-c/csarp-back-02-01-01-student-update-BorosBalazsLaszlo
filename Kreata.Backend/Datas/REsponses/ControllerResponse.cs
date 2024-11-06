using Kreta.Backend.Datas.REsponses;

namespace Kreta.Backend.Datas.REsponses
{
    public class ControllerResponse : ErrorStore
    {
        public bool IsSuccess => !HasError;

        public ControllerResponse() : base() { }
    }
}