using Data_Access_Hotel_Management_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business_Hotel_Management_System
{
    public class clsRooms
    {
        public enum enStatusRooms {enVacant=1,enReserved=2,enCleaning=3,enMaintentenance=4 };

        private static  enStatusRooms GetStatus(int RoomID)
        {
         return (enStatusRooms)  clsRoomsData.FindStatusRoom(RoomID);
        }
        public enum enMode { enAddNew = 1, enUpdate=2}
        enMode _Mode = enMode.enAddNew;
        public int RoomID { set; get; }
        private int _TypeRoomID { set; get; }

        public int TypeRoomID { get { return _TypeRoomID; }set {

                _TypeRoomID=value;
                this.TypeRoomInfo=clsTypeRooms.FindTypeRoom(_TypeRoomID);
            } }
        public clsTypeRooms TypeRoomInfo { set; get; }
        public string Notes {  set; get; }
        public enStatusRooms RoomStatus {  set; get; }
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
        public clsUser UserInfo { set; get; }
        public string TextRoomStatus
        {

            get {
                if (this.RoomStatus == enStatusRooms.enVacant)
                    return "Vacant";
                if (this.RoomStatus == enStatusRooms.enMaintentenance)
                    return "Maintentenance";
                if (this.RoomStatus == enStatusRooms.enCleaning)
                    return "Cleaning";
                if (this.RoomStatus == enStatusRooms.enReserved)
                    return "Reserved";

                return "Error In Status..";
            }
                
            
        }
        public clsRooms()
        {
            this.RoomID=-1;
            this.TypeRoomID=-1;
            TypeRoomInfo = new clsTypeRooms();
            this.Notes="";
            this.RoomStatus=enStatusRooms.enVacant;
            this.CreatedByUserID=-1;
            this.UserInfo=new clsUser();
            this._Mode=enMode.enAddNew;
        }
        public clsRooms(int RoomID,int TypeRoomID,string Notes,enStatusRooms RoomStatus, int CreatedByUserID)
        {
            this.RoomID=-1;
            this.TypeRoomID=-1;
            this.TypeRoomInfo=clsTypeRooms.FindTypeRoom(TypeRoomID);
            this.Notes="";
            this.RoomStatus=RoomStatus;
            this.CreatedByUserID=-1;
            this.UserInfo=clsUser.FindByUserID(CreatedByUserID);
            this._Mode=enMode.enUpdate;

        }

        public static clsRooms FindRoomByID(int RoomID)
        {
            int TypeRoomID = -1;float Fees = 0;
             string Notes = ""; int Status = 0;  int CreatedByUserID = -1;
            
            if(clsRoomsData.FindRoomByID(RoomID,ref TypeRoomID,ref Notes,ref Status,ref CreatedByUserID))
            {
                return new clsRooms(RoomID, TypeRoomID, Notes,(enStatusRooms) Status, CreatedByUserID);
            }
            return null;
        }

        private bool _AddNewRoom()
        {
            this.RoomID =clsRoomsData.AddNewRoom(this.TypeRoomID,(byte)this.RoomStatus, this.Notes,this.CreatedByUserID);

            if(this.RoomID>=1 )
            {
                return true;
            }
            return false;
        }

        private bool _UpdateRoom()
        {
            bool IsUpdate =clsRoomsData.UpdateRoom(this.RoomID,this.TypeRoomID,(byte) this.RoomStatus, this.Notes, this.CreatedByUserID);

            if (IsUpdate)
            {
                return true;
            }
            return false;
        }
        public static bool UpdateStatusRoom(int RoomID,byte Status, int LastUpdatedStatusByUserID)
        {
            return clsRoomsData.UpdateStatusRoom(RoomID,Status, LastUpdatedStatusByUserID);
        }
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.enAddNew:
                    if (_AddNewRoom())
                    {
                        _Mode= enMode.enUpdate;
                        return true;
                    }
                    break;
                case enMode.enUpdate:
                    if (_UpdateRoom())
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        public static DataTable GetAllRooms()
        {
          
            return clsRoomsData.GetAllRooms();
        }
        
        public static bool DeleteRoom(int RoomID)
        {
            return clsRoomsData.DeleteRoom(RoomID);
        }

        public static bool IsVacantRoom(int  RoomID)
        {
            if(GetStatus(RoomID)==enStatusRooms.enVacant)
                return true;
            else return false;
        }
        public static bool IsReservedRoom(int RoomID)
        {
            if (GetStatus(RoomID)==enStatusRooms.enReserved)
                return true;
            else return false;
        }

        public static bool IsCleaningRoom(int RoomID)
        {
            if (GetStatus(RoomID)==enStatusRooms.enCleaning)
                return true;
            else return false;
        }
        public static bool IsMaintentenanceRoom(int RoomID)
        {
            if (GetStatus(RoomID)==enStatusRooms.enMaintentenance)
                return true;
            else return false;
        }
    }
}
