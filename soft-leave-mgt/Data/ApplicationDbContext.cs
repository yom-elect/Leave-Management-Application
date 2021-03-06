﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using soft_leave_mgt.Models;

namespace soft_leave_mgt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<soft_leave_mgt.Models.LeaveRequestVM> LeaveRequestVM { get; set; }

        /*public DbSet<soft_leave_mgt.Models.LeaveTypeVM> DetailsLeaveTypeVM { get; set; }
        public DbSet<soft_leave_mgt.Models.EmployeeVM> EmployeeVM { get; set; }
        public DbSet<soft_leave_mgt.Models.LeaveAllocationVM> LeaveAllocationVM { get; set; }
        public DbSet<soft_leave_mgt.Models.EditLeaveAllocationVM> EditLeaveAllocationVM { get; set; }*/
    }
}
