using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concrete;
using HotelProject.DataAccesLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.EntityFramework
{
    public class EFBookingDal : GenericRepository<Booking>, IBookingDal
    {
        private readonly Context _context;
        public EFBookingDal(Context context) : base(context)
        {
            _context = context;
        }

        public void BookingStatusChangeApproved(int id)
        {
            _context.Bookings.Find(id).Status = "Onaylandı";
            _context.SaveChanges();
        }
        public void BookingStatusChangeCancel(int id)
        {
            _context.Bookings.Find(id).Status = "İptal Edildi";
            _context.SaveChanges();
        }
        public void BookingStatusChangeHold(int id)
        {
            _context.Bookings.Find(id).Status = "Müşteri Aranacak";
            _context.SaveChanges();
        }
    }
}
