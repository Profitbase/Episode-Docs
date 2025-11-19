# Key Capabilities

<br/>

- **Context-bound messaging**  
  Each chat instance is associated with a defined context scope (e.g., workbook page, filter state, selected row or object). Messages are stored together with the assigned context to ensure discussions remain relevant to the data being reviewed.
<br/>
<br/>
- **Multiple chat instances per Workbook**  
  Solution developers can add multiple independent chat components into a Workbook. This allows for fine-grained collaboration use cases such as:  
  - One chat per page or dashboard  
  - A global chat accessible from a popup  
  - Chats tied to specific entities or detail views (e.g., per customer record or project)
<br/>
<br/>
- **Real-time communication**  
  New messages are synchronized in real time for all users currently viewing the same context.
<br/>
<br/>
- **Notification integration**  
  To support asynchronous collaboration, a Flow can be triggered if a user does not see a new message within **5 minutes**. The Flow can then send an external notification (Email or Microsoft Teams) to ensure users are alerted to unread messages.

<br/>

#### Usage Scenarios

- Analyst collaboration on dashboards  
- Cross-team review of reports  
- Commenting on data points or anomalies  
- Approval / feedback workflows tied to records

<br/>