using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSolidPrinciples.DIP.Solution;
internal interface IEmployeeDataAccessLogic
{
    Employee GetEmployeeDetails(int id);
}
