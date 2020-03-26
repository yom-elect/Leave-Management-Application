﻿using Microsoft.EntityFrameworkCore;
using soft_leave_mgt.Contracts;
using soft_leave_mgt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soft_leave_mgt.Repository
{
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveRequestRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveRequest entity)
        {
            _db.LeaveRequests.AddAsync(entity);
            return Save();
        }

        public bool Delete(LeaveRequest entity)
        {
            _db.LeaveRequests.Remove(entity);
            return Save();
        }

        public ICollection<LeaveRequest> FindAll()
        {
            var leaveRequests = _db.LeaveRequests
                 .Include(q => q.RequestingEmployee)
                 .Include(q => q.ApprovedBy)
                 .Include(q => q.LeaveType)
                 .ToList();
            return leaveRequests;
        }

        public LeaveRequest FindById(int id)
        {
            var leaveRequest = _db.LeaveRequests
                .Include(q => q.RequestingEmployee)
                .Include(q => q.ApprovedBy)
                .Include(q => q.LeaveType)
                .FirstOrDefault(q => q.Id == id);
            return leaveRequest;
        }

        public ICollection<LeaveRequest> GetLeaveRequestsByEmployee(string employeeid)
        {
            var leaveRequests = FindAll();
            return leaveRequests.Where(q => q.RequestingEmployeeId == employeeid)
            .ToList();
        }

        public bool isExists(int id)
        {
            var exists = _db.LeaveTypes.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }
         public bool Update(LeaveRequest entity)
        {
                _db.LeaveRequests.Update(entity);
                return Save();
        }
    }
}
