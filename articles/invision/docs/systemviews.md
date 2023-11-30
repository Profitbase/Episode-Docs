
# System Views

## SYS_AccessGroups
<br/>

Returns information about all Access Groups.

**Example**

```
SELECT [AccessGroupID]
      ,[Name]
      ,[Type]
  FROM [SYS_AccessGroups]
```

<br/>

## SYS_Objects

<br/>

Returns information about Solution objects.

**Example**

```
SELECT [ObjectID]
      ,[Name]
      ,[SolutionID]
      ,[ObjectType]
      ,[ObjectSubType]
      ,[WorkProcess_ID]
      ,[WorkProcess_Name]
      ,[WorkProcessVersion_ID]
      ,[WorkProcessVersion_Name]
  FROM [SYS_Objects]
```

<br/>

## SYS_ObjectPermissions

<br/>

Returns information about published user permissions on Solution objects.

**Example**

```
SELECT [UserUID]
      ,[UserName]
      ,[ObjectID]
      ,[ObjectName]
      ,[ObjectType]
      ,[SolutionID]
      ,[HasAccess]
  FROM [SYS_ObjectPermissions]
```

<br/>

**Example**

```
SELECT HasAccess 
FROM SYS_ObjectPermissions 
WHERE UserUID = 'user id' AND ObjectID = 'object id'
```

<br/>



## SYS_WorkProcessVersions

<br/>

Returns information about Work Processes and Work Process Versions.

**Example**

```
SELECT [WorkProcess_ID]
      ,[WorkProcess_Name]
      ,[WorkProcessVersion_ID]
      ,[WorkProcessVersion_Name]
  FROM [SYS_WorkProcessVersions]
```

<br/>

## SYS_Solutions

<br/>
Returns information about Solutions.

**Example**

```
SELECT [SolutionID]
      ,[Name]
      ,[WorkProcess_ID]
      ,[WorkProcess_Name]
      ,[WorkProcessVersion_ID]
      ,[WorkProcessVersion_Name]
  FROM [SYS_Solutions]

```

<br/>

## SYS_Tables

<br/>
Returns information about all tables and views in Solutions.

**Example**

```
SELECT [TableName]
      ,[ObjectID]
      ,[SolutionID]
      ,[MetaType]
      ,[TableType]
      ,[WorkProcess_ID]
      ,[WorkProcess_Name]
      ,[WorkProcessVersion_ID]
      ,[WorkProcessVersion_Name]
  FROM [SYS_Tables]

```
