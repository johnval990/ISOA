using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotraser.Isoa.Common.Exception
{
    public class ExceptionHandler : System.Exception
    {
        public ExceptionHandler() : base()
        {
        }

        public ExceptionHandler(string message) : base(message)
        {
        }

        public ExceptionHandler(System.Exception innerException)
        {
            throw new ExceptionHandler(innerException.Message, innerException);
        }

        public ExceptionHandler(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Representa una excepción de un usuario no existente.
    /// </summary>
    public class UserNotExistException : ExceptionHandler
    {

    }

    /// <summary>
    /// Representa una excepción de una contraseña invalida.
    /// </summary>
    public class InvalidPasswordException : ExceptionHandler
    {

    }

    /// <summary>
    /// Representa una excepción de un usuario inactivo.
    /// </summary>
    public class InactiveUser : ExceptionHandler
    {

    }
}
