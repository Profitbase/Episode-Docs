# Flow API

Use the Flow API to execute Flows in the Solution.

The Flow API must be called from a [Function](../functions.md) with the `Async` option set to `true`.

```typescript
execute(name: string, request: { environment?: 'Development' | 'Test' | 'Production'; data?: any }): Promise<any>
```

> [!NOTE]
> Note that the `environment` property in the request payload is optional. If not specified, the environment specified by the `FLOW_ENVIRONMENT` Solution Variable is used.

## Example

This example shows how to execute the Flow named "Get Contract" which exists in the same Solution as the Form Schema.

```xml
<Function Name="getContract" Async="true">
    const contractInfo = await this.flow.execute("Get Contract", {
        data: {
            contractId: this.models.Contract.ContractId
        }
    });

    // Do something with the contract info
    console.log(contractInfo.name);
</Function>
```xml