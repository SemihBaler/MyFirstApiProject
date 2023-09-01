using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TBookingStatusChangeApproved(int id)
        {
            _bookingDal.BookingStatusChangeApproved(id);
        }

        public void TBookingStatusChangeCancel(int id)
        {
            _bookingDal.BookingStatusChangeCancel(id);
        }

        public void TBookingStatusChangeHold(int id)
        {
            _bookingDal.BookingStatusChangeHold(id);
        }

        public void TDelete(Booking t)
        {
            _bookingDal.Delete(t);
        }
    

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);   
        }

        public List<Booking> TGetlist()
        {
            return _bookingDal.Getlist();
        }

        public void Tinsert(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public void TUpdate(Booking t)
        {
            _bookingDal.Update(t);
        }
    }
}
