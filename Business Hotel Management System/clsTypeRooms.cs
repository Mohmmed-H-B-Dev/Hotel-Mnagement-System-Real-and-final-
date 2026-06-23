using Data_Access_Hotel_Management_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Business_Hotel_Management_System
{
    public class clsTypeRooms
    {
        public int TypeRoomID {  get; set; }    
        public string TypeName {  get; set; }
        public string Descriptions { get; set; }
        public float FeesForDay { get; set; }
        public float FeesForMonth { get; set; }
        private int _CreatedByUserID { set; get; }

        public int CreatedByUserID
        {
            get { return _CreatedByUserID; }
            set
            {
                _CreatedByUserID=value;
                this.UserInfo=clsUser.FindByUserID(value);
            }
        }
        public clsUser UserInfo { get; set; }
        public clsTypeRooms()
        {
            this.TypeRoomID=-1;
            this.TypeName="";
            this.Descriptions="";
            this.FeesForDay=0;
            this.FeesForMonth=0;
            this.CreatedByUserID=-1;
            this.UserInfo=null;
        }
        public clsTypeRooms(int TypeRoomID,string TypeName,string Descriptions,float FeesForDay,float FeesForMonth,int CreatedByUserID )
        {
            this.TypeRoomID=TypeRoomID;
            this.TypeName=TypeName;
            this.Descriptions=Descriptions;
            this.FeesForDay=FeesForDay;
            this.FeesForMonth = FeesForMonth;
            this.CreatedByUserID=CreatedByUserID;
            this.UserInfo=clsUser.FindByUserID(CreatedByUserID);
        }

        public static clsTypeRooms FindTypeRoom(int TypeRoomID)
        {
            string TypeName = ""; string Descriptions = "";
            float FeesForDay = 0;
            float FeesForMonth = 0; int CreatedByUserID=-1;

            if (clsTypeRoomData.FindTypeRoom(TypeRoomID,ref TypeName,ref Descriptions,ref FeesForDay,ref FeesForMonth, ref CreatedByUserID))
            {
                return new clsTypeRooms(TypeRoomID,TypeName, Descriptions, FeesForDay,FeesForMonth,CreatedByUserID);
            }
            return null;
            
        }

        public static clsTypeRooms FindTypeRoom(string TypeName)
        {
            int TypeRoomID=0 ; string Descriptions = "";
            float FeesForDay = 0;
            float FeesForMonth = 0; int CreatedByUserID = -1;
            if (clsTypeRoomData.FindTypeRoom(TypeName, ref TypeRoomID, ref Descriptions, ref FeesForDay,ref FeesForMonth, ref CreatedByUserID))
            {
                return new clsTypeRooms(TypeRoomID, TypeName, Descriptions, FeesForDay, FeesForMonth, CreatedByUserID);
            }
            return null;

        }
        public static DataTable GetAllTypeRooms()
        {
            return clsTypeRoomData.GetAllTypeRooms();
        }
    }
}
