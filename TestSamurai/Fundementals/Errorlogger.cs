﻿namespace TestSamurai.Fundementals
{
    public class ErrorLogger
    {
        public string LastError { get; set; }

        public event EventHandler<Guid> ErrorLogged;

        public void Log(string error)
        {
            // null
            // ""
            // " "
            if (string.IsNullOrWhiteSpace(error))
            {
                throw new ArgumentNullException();
            }

            LastError = error;

            // Write the log to a storage
            // ...

            ErrorLogged?.Invoke(this, Guid.NewGuid());
        }
    }
}
