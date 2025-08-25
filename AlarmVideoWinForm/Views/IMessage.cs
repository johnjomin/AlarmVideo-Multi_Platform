using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmVideoWinForm.Views
{
    interface IMessage
    {
        string MessageInput { get; set; }
        string GetResult { get; set; }
        string ResultAlarmId { get; set; }
        string ResultVideoServerNo { get; set; }
        string ResultMessage { get; set; }
        string ExceptionMessage { get; set; }
    }
}
