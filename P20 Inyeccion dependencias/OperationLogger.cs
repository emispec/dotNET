using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class OperationLogger
{
    private readonly ITranstientOperation _transientOperation;
    private readonly IScopedOperation _scopedOperation;
    private readonly ISingletonOperation _singletonOperation;

    public OperationLogger(
        ITranstientOperation transtientOperation,
        IScopedOperation scopedOperation,
        ISingletonOperation singletonOperation
    ) => (_transientOperation, _scopedOperation, _singletonOperation) = (transtientOperation, scopedOperation, singletonOperation);

    public void LogOperations(string scope)
    {
        LogOperations(_transientOperation, scope, "Desde TransientOperation");
        LogOperations(_scopedOperation, scope, "Desde ScopedOperations");
        LogOperations(_singletonOperation, scope, "Desde SingletonOperation");
    }

    private static void LogOperation<T>(T operation, string scope, string msg)
    where T : IOperation => System.Console.WriteLine($"{scope}: {typeof(T).Name, -19} [{operation.OperationId} - {msg, -23}]");


}
