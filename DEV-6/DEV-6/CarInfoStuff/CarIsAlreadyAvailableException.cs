using System;

namespace DEV_6
{
    class CarIsAlreadyAvailableException : Exception
    {
        public CarIsAlreadyAvailableException(string message) : base(message)
        {
            
        }
    }
}
