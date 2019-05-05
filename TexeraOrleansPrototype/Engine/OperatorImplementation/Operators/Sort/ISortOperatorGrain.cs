using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Engine.OperatorImplementation.Common;

namespace Engine.OperatorImplementation.Operators
{
    public interface ISortOperatorGrain<T> : IWorkerGrain where T:IComparable<T>
    {
    }

}