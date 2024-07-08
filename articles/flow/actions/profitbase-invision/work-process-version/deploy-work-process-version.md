# Deploy work process version

This action deploys a version of a work process. It creates a solution based on selected content from the work process blueprint selection. The state of this version will be marked as deployed.

![wpv](https://profitbasedocs.blob.core.windows.net/flowimages/Deploy-wpv.png)

## Properties

| Name                 | Type     | Description                         |
|----------------------|----------|-------------------------------------|
| Title                | Optional |                                     |
| Connection           | Required | InVision connection                 |
| Work Process Version | Required | Select Work Process Version from the list |
| Include information messages in log | Optional |                      |
| Changed by           | Optional |                                     |
| Result variable name | Optional |                                     |
| Description          | Optional |                                     |