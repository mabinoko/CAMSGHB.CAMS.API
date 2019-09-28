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

        }
    }
}
