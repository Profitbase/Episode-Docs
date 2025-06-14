# Allocation

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.4 or later.  <br/>

This is the setup page for allocation rules. Allocation rules allows for re-allocation (of typically cost) between departments in the same legal entity.  <br/> 

The re-allocation is typically set up from a non-producing or shared services department (giver) to a number of producing departments (bearers) for reporting "full cost".  <br/>

Note that the re-allocation is "non-cash", i.e. assumes no buying and selling between the giver and bearer departments and thus no need for handling of intercompany differences and eliminations. The allocation is therefore done after the execution of the financial engines. Results of the allocations is fed back to the plan overview allowing for input reports that includes allocated cost and is part of the dataset made available for Finance Reports. The following illustration attempts to visualize where in the flow of data the allocation function fits in:  <br/>

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/Allocation.JPG)<br/>

The setup allows you to create one or more allocation rules (e.g. Marketing cost, IT cost, etc) and to associate different giver-bearer relationships, allocation keys (how giver's cost is allocated between bearers) as well as defining which accounts make up giver's cost for each individual rule.  <br/>

Use cases: <br/> 

- re-allocation from giver department to bearer departments based on a pre-defined (fixed) ratio between bearers.  <br/>

- re-allocation from giver department to bearer departments based on a dynamic keys for the various bearers. Measures in use in the solution (from driver based models or the personnel module such as FTE, Sales qty, etc., as well as report lines associated with the input report such as Sales. Note that for report lines, sum lines that are made up of lines that are mapped to accounts may be used, e.g. Total sales. However, sum lines that are made up of other sum lines are not suppported.<br/>

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/AllocationSetup.JPG)<br/>

The setup screen consists of the following parts:

- Buttons<br/>
    - New - create new rule<br/>
    - Save - save changes to setup<br/>
    - Refresh - reload content, unsaved changes are lost<br/>
    - Delete - Delete selected rule<br/>
    - Execute - execute (run) currently selected allocation rule<br/>
- Filters (left margin)<br/>
    - Allocation rule - filter that allows you to select a specific allocation rule<br/>
    - Giver - filter that allows you to select a specific giver<br/>
    - Bearer - filter that allows you to select a specific bearer<br/>
- Main area - sub-screens with setup tables and reports<br/>
    - Allocation rule - input table for setting the name of the rule, as well as main rule properties such as:<br/>
        - Allocation key - either select fixed ratio (and enter ratio between bearers in the Giver - Bearer input table) or select a measure or report line (allocation keys automatically calculated based on current data)<br/>
        - Account - the account to which allocated cost for the rule is attributed. **Note** It is best practise to use separate allocation accounts for each rule for traceability and reporting.<br/>
        - Sequence - the sequence of execution (between rules). If a certain rule depends on the output of another rule, make sure to set a higher ssequnce number.<br/>
        - Enabled - (true | false) only rules that are set to enabled = true are in effect. Any enabled rules are automatically calculated when the finance baseline is executed.<br/>
        - Full dimensionality - (true | false) if set to true, the full dimensionality of the source transactions are used when producing the allocation transactions. If set to false, allocation transactions are aggregated to legal entity, department and account. **Note** In a production environment, full dimensionality should always be set to false due to potentially large amounts of data. Set to true only for quality assurance / debugging.<br/>
        - Additional key filter - applies to allocation keys other than fixed ratio, valid part of sql where clause. In certain situations it may be desirable to limit/split the allocation key by another dimension. If for example, the measure Sales qty is used, one might specify and additional key filter ProductID = 'BMW' to limit the sales quantity measure to a certain make. **Note** Only one dimension is supported. Eligible dimension ids are LegalEntityID, DepartmentID, AccountID, ProductID, MarketID, ProjectID, EmployeeID, ActivityID, Dim1, Dim2, Dim3, Dim4.<br/>
        - Comment - free text.<br/>
    - Giver - Bearer - setup table for giver - bearer relationships<br/>
		Note that the setup of giver - bearer can either be done directly in the available table by adding row by row and individually selecting givers and bearer or by the use of the "Select from dimension" function which allows you to select higher level dimensional nodes for bearers:<br/>
		
		Select from dimension:<br/>
		
		![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/AllocationGiverBearerDimension.JPG)<br/>
		
		In the leftmost part, add new giver rows by right-clicking in the table and selecting "Insert row". A giver is always a lowest level department. Having added a giver, click the "Select" icon next to the giver in question. This will load the middle and right-most parts that displays a bearer selector in the middle part and the selected bearers in the rightmost part. 
		
		In the middle, bearer selection part, the organisation hierarchy is available as the selector. Both aggregate and lowest level nodes can be selected, single or multiple. Note that when selecting an aggregate node, this automatically implies that all lowest level nodes below the selected aggregate node is automatically considered as bearers.
		
		The rightmost "Selected bearers" part is automatically refreshed as selections are made in the middle part and reflects all lowest level nodes that will be treated as bearers to the selected giver.<br/>
		
		Once done, click Save to save the selection keeping in mind that any previous saved selection will be overwritten.<br/>
		
		A benefit of using the "Select from dimension" method is that any changes in the hierarchy below selected bearer is automatically reflected in the actual lowest level bearers once the dimensional changes are published to the Planner version in question.<br/>
		
		Maintain giver-bearer table manually:<br/>
        - Giver - select giver department<br/>
        - Bearer - select bearer department<br/>
        - Fixed ratio - set a fixed ratio for the bearer. Only relevant if allocation key is set to fixed ratio.<br/>
        - Comment - free text<br/>
    - Source Definition - setup table for accounts that make up the giver's cost<br/>
		Note that the setup of source definition can either be done directly in the available table by adding row by row and individually selecting source accounts or by the use of the "Select from dimension" function which allows you to select higher level dimensional nodes for source accounts:<br/>
		
		Select from dimension:<br/>
		
		![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/AllocationSourceDefinitionDimension.JPG)<br/>	
		
		In the leftmost part, select one or more nodes from the account dimensions so that they combined make up the entire source definition. Note that aggregate nodes can be selected, for example account group "5 payroll expenses", etc. Note that when selecting an aggregate node, this automatically implies that all lowest level nodes below the selected aggregate node is automatically considered as source accpunts.<br/>
		
		The rightmost part is automatically refreshed and reflects all lowest level accounts resulting from the selected nodes and will as such make up the source accounts.<br/>
		
		Once done, click Save to save the selction keeping in mind that any previous saved selection will be overwritten.<br/>
		
		A benefit of using the "Select from dimension" method is that any changes in the hierarchy below selected account group is automatically reflected in the actual lowest level source accounts once the dimensional changes are published to the Planner version in question.<br/>
		
		Maintaing source deinition table manually:<br/>
        - Account - select account.<br/>
        - Enabled - (true | false) set to true if account is to be included.<br/>
        - Comment - free text.<br/>
	- QA - reports for quality assurance of allocation keys and allocation transactions<br/>
		- The following reports are useful for controlling the output. Requires that the allocation rule is executed, use the Execute button.<br/>
			- Allocation keys - displays the key for the various bearers.<br/>
			- Allocation transactions - displays the first 1000 allocation transactions produced.<br/>
