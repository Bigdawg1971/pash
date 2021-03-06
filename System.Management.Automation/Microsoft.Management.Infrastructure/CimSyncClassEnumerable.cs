using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Native;
using Microsoft.Management.Infrastructure.Options;
using Microsoft.Management.Infrastructure.Options.Internal;
using System;

namespace Microsoft.Management.Infrastructure.Internal.Operations
{
	internal class CimSyncClassEnumerable : CimSyncEnumerableBase<CimClass, CimSyncClassEnumerator>
	{
		private readonly bool _shortenLifetimeOfResults;

		internal CimSyncClassEnumerable(CimOperationOptions operationOptions, Func<CimAsyncCallbacksReceiverBase, OperationHandle> operationStarter) : base(operationOptions, operationStarter)
		{
			this._shortenLifetimeOfResults = operationOptions.GetShortenLifetimeOfResults();
		}

		internal override CimSyncClassEnumerator CreateEnumerator()
		{
			return new CimSyncClassEnumerator(this._shortenLifetimeOfResults);
		}
	}
}