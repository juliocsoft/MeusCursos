﻿namespace GTSharp.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public string Message { get; set; }

        public ResponseBase()
        {
            Message = Resources.Message.SuccessOperation;
        }
    }
}
