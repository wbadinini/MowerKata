using System;

namespace MowerKata.Exceptions
{
    public class InvalidCommandFormatException : Exception
    {
        public override string Message => "Invalid command format";
    }
}