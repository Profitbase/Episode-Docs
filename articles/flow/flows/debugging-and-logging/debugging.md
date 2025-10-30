# Node Debugger

The node debugger lets you inspect data flowing through an individual node after a flow execution has completed in the designer. It provides a multi-panel view to explore and/or export the data that was present on a nodes input and output ports during the flow execution.

<br>

## Opening the Dialog

You open the debugger dialog by either clicking the appearing button above the node when your mouse pointer hovers over the node or by right-clicking the node and choosing'View debugger'.

<img src="../../../../images/debugger-open.png" alt="Opening debugger dialog">
<p><em>Figure: The debugger dialog can be opened via the hover action button or by right-clicking the node and selecting “View debugger”.</em></p>

<br>


<img src="../../../../images/debugger-overview-full.png" alt="Debugger dialog with runs and iterations">
<p><em>Figure: Debugger dialog showing 8 runs, each producing 6 loop iterations.</em></p>

<br>

Each dialog is unique to a specific session ID and node ID. If you need these IDs, you can copy them to the clipboard by clicking NID or DSID in the footer. If you try to open the same dialog twice, the existing window is simply brought to the front. The window is resizable and can remain open even during flow execution. The dialog’s data will be reloaded once the execution is complete.

<br>

## Concept Glossary

| Term | Meaning |
|------|--------|
| Run | A single execution instance of the node. |
| Port | A specific input or output port on the node. |
| Iteration | Sequential port trace occurrences within a run; useful when ports receive values multiple times (loops). |
| Debugger item | Raw trace item containing metadata (e.g., run index, port id, iteration, media type and data). |

<br>

## Layout Overview

The interface is split into collapsible/resizable panels on the left and a data panel on the right:

1. Runs Panel **\***
2. Ports Panel
3. Iterations Panel **\***
4. Data Panel

**\*** Collapsed if the Node was executed only once and produced only one result on the output, during the flow execution.

**Panels can be:**
- Resized by dragging the vertical line grip.
- Collapsed/expanded with a pin button (collapsed panels show a vertical rotated label).


<br>
<br>

## Panel Details

<br>

### Runs Panel
Shows all distinct run numbers (the number of times a node was called during the flow execution) in ascending order.  
Visible only when there is more than one run. Selecting a run filters available trace items for downstream panels.
<br>

### Ports Panel
Lists the ports encountered in the trace data for the node.  
Port entries display the port’s name and direction ( [IN] to the node or [OUT] from the node).  
Selecting a port filters iterations and narrows data to that (run + port) combination.
<br>

### Iterations Panel
Shows iteration numbers within the selected run/port. This panel is only relevant when the node itselv iterates and produces its output value multiple times during the execution. This is typically the case for nodes that loops.
<br>

### Data Panel
Displays the payload of the active trace item determined by (Run, Port, Iteration).  


**Table View**
- Auto-generated columns from the first object's keys.
- Column filtering (multiple filters combine via union logic).
- Column sorting (click arrow icons).
- Line number toggle.
- Pagination controls.
- Column visibility toggling.
- Copy to clipboard (clicking a cell copies its raw value).

**JSON View**
- Collapsible, pretty-formatted JSON tree.
- Expand/collapse nodes to focus on relevant sections.
- Inline syntax coloring for improved readability.

**Both Views**
- Export actions (JSON, CSV, tab-delimited).
- Binary / media handling: when marked binary, inline parsing is skipped; use “Open in browser” to attempt viewing. If the browser supports the media type it opens inline; the file is always downloaded.

## Supported Media & Inline Preview

The code attempts inline open only for commonly safe types:
- Text (`text/plain`, `application/json`, `text/*`)
- Images (`image/png`, `image/jpeg`, `image/gif`, `image/webp`, etc.)
- Simple structured formats (CSV) may open in a new tab depending on browser.

Unsupported or opaque types (binary blobs) will be downloaded.