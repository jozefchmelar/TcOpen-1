﻿using System;
using System.Runtime.Serialization;

namespace TcoCore
{
    public class MultipleRemoteCallInitializationException : Exception
    {
        public MultipleRemoteCallInitializationException()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="MultipleRemoteCallInitializationException"></see> class with serialized data.</summary>
        /// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        /// <exception cref="System.ArgumentNullException">The <paramref name="info">info</paramref> parameter is null.</exception>
        /// <exception cref="System.Runtime.Serialization.SerializationException">The class name is null or <see cref="System.Exception.HResult"></see> is zero (0).</exception>
        protected MultipleRemoteCallInitializationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

        /// <summary>Initializes a new instance of the <see cref="MultipleRemoteCallInitializationException"></see> class with a specified error message.</summary>
        /// <param name="message">The message that describes the error.</param>
        public MultipleRemoteCallInitializationException(string message) : base(message)
        {

        }

        /// <summary>Initializes a new instance of the <see cref="MultipleRemoteCallInitializationException"></see> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public MultipleRemoteCallInitializationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
