# Node Debugger

The node debugger lets you inspect data flowing through an individual node after a flow execution has completed in the designer. It provides a multi-panel view to explore or export the data present on a nodes input and output ports during the flow execution.

<br>

## Opening the Dialog

You open the debugger dialog by either clicking the appearing button above the node when your mouse pointer hovers over the node or by right-clicking the node and choosing 'View debugger'.

<img src="../../../../images/debugger-open.png" alt="Opening debugger dialog">
<p><em>Figure: The debugger dialog can be opened via the hover action button or by right-clicking the node and selecting “View debugger”.</em></p>

<br>


<img src="../../../../images/debugger-overview-full.png" alt="Debugger dialog with runs and iterations">
<p><em>Figure: The debugger dialog showing 8 runs, each producing 6 loop iterations for the "for each Person in PersonsList2" node during the execution of the flow.</em></p>

<br>

Each dialog instance is tied to a session ID (DSID) and node ID (NID). If you need these IDs, click NID or DSID in the footer to copy them. If you try to open the same dialog twice, the existing window is brought to the front. The window is resizable and can remain open during flow execution. Its data reloads once the execution completes.

<br>

## Concept Glossary

| Term | Meaning |
|------|--------|
| Run | A single execution instance of the node. |
| Port | A specific input or output port on the node. |
| Iteration | A sequential occurrence of a port trace within a run (appears when a port receives values multiple times, e.g. in loops). |
| Debugger item | A raw trace record containing metadata (run index, port id, iteration, media type, and data). |

<br>

## Layout Overview

The interface is split into collapsible/resizable panels on the left and a data panel on the right:

1. Runs Panel **\***
2. Ports Panel
3. Iterations Panel **\***
4. Data Panel

**\*** Collapsed if the node was executed only once and produced a single output during the flow execution.

**The panels can all be:**
- Resized by dragging the vertical line grip.
- Collapsed/expanded with the (<) expand/collapse button.
<br>
<br>

## Panel Details

<br>

### Runs Panel
Shows all distinct run numbers (the number of times a node was called during the flow execution) in ascending order.  
Visible only when there is more than one run. Selecting a run filters available trace items for downstream panels.
<br>
<br>

### Ports Panel
Lists the ports encountered in the trace data for the node.  
Port entries display the port’s name and direction ( [IN] to the node or [OUT] from the node).  
Selecting a port filters iterations and narrows data to that (run + port) combination.
<br>
<br>

### Iterations Panel
Shows iteration numbers within the selected run/port. This panel is only relevant when the node itselv iterates and produces its output value multiple times during the execution. This is typically the case for nodes that loops.
<br>
<br>

### Data Panel
Displays the payload of the active debugger item determined by (Run, Port, Iteration).  

**Table View**
- Auto-generated columns from the first object's keys.
- Column filtering (multiple filters combine via union logic).
- Column sorting (click arrow icons).
- Line number toggle.
- Pagination controls.
- Column visibility toggling.
- Copy to clipboard (clicking a cell copies its raw value).
- Export actions (JSON, CSV, tab-delimited).

**JSON View**
- Collapsible, pretty-formatted JSON tree.
- Expand/collapse nodes to focus on relevant sections.
- Inline syntax coloring for improved readability.
- Export actions (JSON, CSV, tab-delimited).

**Bindary data handling**
- Binary / media handling: if marked binary, inline parsing is skipped; use “Open in browser” to attempt viewing. If the browser supports the media type it opens and displays the data inline. The binary file will always be downloaded to the browsers download folder.
<br>

<img src="../../../../images/debugger-binary-data.png" alt="Binary data handling">
<p><em>Figure: Binary data will be attempted opened inline in the browser for some supported types. The data will always be downloaded to you download folder if the "open in browser" button is pressed.</em></p>

<br>
<br>

## Supported Media & Inline Preview

The code attempts inline open only for commonly safe types:
- Text (`text/plain`, `application/json`, `text/*`)
- Images (`image/png`, `image/jpeg`, `image/gif`, `image/webp`, etc.)
- Simple structured formats (CSV) may open in a new tab depending on browser.

Unsupported or opaque types (binary blobs) are downloaded.