# Data Capture

Data Capture captures manually entered financial data. Input can be entered as Periodic or Year-to-Date (YTD) values. YTD input is recommended because it preserves the correct YTD for the current reporting period when previous periods are corrected in the ERP system.

## Overview

- Purpose: collect manual adjustments, forecast entries or any financial data not available from the ERP.
- Recommended mode: Year-to-Date (YTD) to avoid having to update historical periods after corrections.
- Publish: users must click Publish to submit data to the system.

## Input

1. Select Fiscal Year, Period and Legal Entity.
2. If no rows exist for the selected period, click Add Row.
3. Paste or enter values into the grid.
4. Ensure required identifier columns are present (see Required fields).
5. Click Publish to submit the data.

Tip: Use copy/paste from spreadsheets for faster entry.

### Required fields and identifiers

- AccountID or AccountSrcID — one of these must be supplied. Showing both is unnecessary.
- Type ID — usually auto-populated from the Account dimension; manual entry is rarely required.

## Periods

The Periods view shows a monthly overview of numbers entered in the input sheet so users can review values across months.

## Status

The Status page shows a log of submitted periods, including:

- Period submitted
- User who submitted
- Timestamp

Use the status log to track who published data and when.

## Settings

Use the Settings page to:

- Define which measures are available for input per legal entity.
- Choose the input mode (Periodic or Year-to-Date).
- Control visibility of identifiers (AccountID vs AccountSrcID).

Recommendations:

- Prefer Year-to-Date input.
- Only show the identifier you need (AccountID or AccountSrcID) to reduce user error.
