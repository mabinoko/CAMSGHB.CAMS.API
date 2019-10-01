using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAMSGHB.CAMS.API.Enum
{
    public class EnumMessage
    {
        public struct StatusMessage
        {
            public struct Success
            {
                public const string DataSaved = "ระบบทำการบันทึกข้อมูล เรียบร้อยแล้ว";

                public const string DataSaveChange = "ระบบทำการบันทึกข้อมูลที่แก้ไข เรียบร้อยแล้ว";

                public const string DataIsDeleted = "ระบบทำการลบข้อมูล เรียบร้อยแล้ว";
            }

            public struct Error
            {
                public const string NotFoundUpdate = "ไม่พบข้อมูลที่ต้องการแก้ไข";
            }

        }

        public class connectionString
        {
            public const string connect = "Server=207.148.69.13;Database=DBCams3;User ID=os1;Password=os1";
        }


        public class DateFormatConverter : IsoDateTimeConverter
        {
            public DateFormatConverter(string format)
            {
                DateTimeFormat = format;
            }
        }

    }
}
