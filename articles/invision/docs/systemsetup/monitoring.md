
# Monitoring

Telemetry and health state configuration can be edited in the **appsettings.json** file for the **Dispatcher**, **Scheduler**, **Worker** and **WebApp** services.

<br/>


## Setting up Application Insights

To enable heartbeat metrics and/or logging to Application Insights; edit the following sections to set the instrumentation key and heartbeat interval:

>**Example**
>
        "Monitoring": {
          "DiagnosticsType": "ApplicationInsights",
          "ApplicationInsights": {
            "InstrumentationKey": "YOUR_INSTRUMENTATION_KEY_GOES_HERE"
          },
          "HealthChecks": {
            "Mode": "Send",
            "HealthChecksSend": {
              "Target": "ApplicationInsights",
              "Interval": "0.00:15:00"
              }
            }
          }

<br/>

## Setting up health checks

To disable ApplicationInsights or change the health state path; edit the following sections:


>**Example**
>
        "Monitoring": {
          "DiagnosticsType": "ApplicationInsights",
          "ApplicationInsights": {
            "InstrumentationKey": "YOUR_INSTRUMENTATION_KEY_GOES_HERE"
          },
          "HealthChecks": {
            "Mode": "Endpoint",
            "HealthChecksSend": {
              "Target": "ApplicationInsights",
              "Interval": "0.00:15:00"
            },
            "HealthChecksEndpoint": {
              "Route": "/health"
              }
            }
          }



<br/>

## See Also  
* [HTTP API](monitoring/httpapi.md)
  
<br/>