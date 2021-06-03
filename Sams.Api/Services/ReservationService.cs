using Microsoft.EntityFrameworkCore;
using Sams.Data;
using Sams.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sams.Api.Services
{
    public class ReservationService
    {
        private readonly SamsContext _context;

        public ReservationService(SamsContext context)
        {
            _context = context;
        }

        public async Task PostReservationAsync(Reservation res)
        {
            _context.Add(res);
            await _context.SaveChangesAsync();
        }

    }
}
