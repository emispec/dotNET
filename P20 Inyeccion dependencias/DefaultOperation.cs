using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class DefaultOperation : ITranstientOperation, IScopedOperation, ISingletonOperation
{
    public string OperationId { get; }
}
