using System;
using System.Collections.Generic;
using System.Text;

namespace Refatorando001.after.Readers
{
    class ReaderResult
    {
        public string Message { get; }
        public object Data { get; }

        public ReaderResult(string message, object data)
        {
            Message = message;
            Data = data;
        }

    }
}
