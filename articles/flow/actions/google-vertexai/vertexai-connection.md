# Connecting to Google VertexAI

Vertex AI connections enable Flow actions to interact with [Google Vertex AI](https://cloud.google.com/vertex-ai?hl=en) resources, such as Large Language Models (LLMs).

<br/>

## How to create a new VertexAI Connection

When adding a Google VertexAI action (such as Agent Model or Chat Completion), you can select an **existing VertexAI connection** or **create a new one**:

1. In the Flowchart, select the action you want to connect.
2. In the property panel, select **Connection**.
3. Toggle **Create New Connection** on.
4. Fill in the required fields:
   - **Name**: Enter a unique, descriptive name.
   - **Location**: Enter the region name (see [Locations](https://cloud.google.com/about/locations)).
   - **Json key**: Paste the JSON key associated with your VertexAI account.

> **Note:** Not all services are available in all locations.

<br/>

## Properties

| Name      | Description |
|-----------|--------------------------|
| Name      | Name of the connection.  |
| Location  | Region (datacenter) where your model runs. See [Locations](https://cloud.google.com/about/locations). Example: `europe-west4`. |
| Json key  | Service Account key for authentication (paste the full content of the JSON file acquired when creating a new key). |

<br/>

### How to obtain the Json key
<br/>

#### 1. Account Setup
1) Sign in or sign up at the [Google Cloud Console](https://console.cloud.google.com/) with your Google account.  
2) Click the Project selector (top bar) → New Project → enter a name → Create.  
3) Ensure Billing is enabled for your project (left menu: Billing).

#### 2. Enable VertexAI API
1) In the Console left menu: APIs & Services → Library.  
2) Search for "Vertex AI API" (`aiplatform.googleapis.com`) → click Enable.

#### 3. Create Service Account
1) In the Console left menu: IAM & Admin → Service Accounts → Create Service Account.  
2) Enter a name/ID and description → Create.  
3) In the Role field, select Vertex AI User.  
4) Click Continue → Done.

#### 4. Create and Download the Json key
1) In the Console left menu: Service Accounts.  
2) On your Service Account row, click the ⋮ button to the right → Manage keys.  
3) Click Add key → Create new key → select JSON → Create.  
4) Download the JSON key file. Paste its full content of this file into the Json key field.

<br/>

