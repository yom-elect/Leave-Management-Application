﻿using soft_leave_mgt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soft_leave_mgt.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        bool CheckAllocation(int leaveTypeId, string employeeId);
        ICollection<LeaveAllocation> GetLeaveAllocationByEmployee(string id);
        LeaveAllocation GetLeaveAllocationByEmployeeAndType(string id, int leavetypeid);

    }
}
