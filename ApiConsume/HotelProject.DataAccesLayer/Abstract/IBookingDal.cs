﻿using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.Abstract
{
    public interface IBookingDal:IGenericDal<Booking>
    {
        void BookingStatusChangeApproved(int id);
        void BookingStatusChangeCancel(int id);
        void BookingStatusChangeHold(int id);
    }
}
