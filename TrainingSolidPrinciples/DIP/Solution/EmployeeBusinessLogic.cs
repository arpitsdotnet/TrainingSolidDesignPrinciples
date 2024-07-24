﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSolidPrinciples.DIP.Solution;
internal class EmployeeBusinessLogic
{
    IEmployeeDataAccessLogic _EmployeeDataAccessLogic;
    public EmployeeBusinessLogic()
    {
        _EmployeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
    }

    public Employee GetEmployeeDetails(int id)
    {
        return _EmployeeDataAccessLogic.GetEmployeeDetails(id);
    }
}
