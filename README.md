# Barcodes-DLL--.NET-
.NET DLL to Generate Barcodes in Bytes, Image, and Base64

This was designed for Microsoft Report Builder to be used as a DLL to provide functionality not currently available.
This was developed as a wrapper to use with Report Builder so that barcodes can be generated.


# Microsoft Report Builder 
You are going to need to add a reference in Report Builder for System.Drawing.dll C:\Windows\Microsoft.NET\Framework\v4.0.30319
And Barcodes.dll and NBarCodes.dll located in this folder.

On the outer report area, right click, Report Properties > References: add those 3 DLLs

Create an Image Object in Report Builder and right click > Image Properties
Data Source: database
Use this Field: =Barcodes.Bytes.UPCA("123456789012")
MineType: image/png

Remember that errors will not be shown in Report Builder. 
For example the UPCA requires exactly 12 digits as per specifiction.

Barcodes.Bytes.UPCA

Barcodes.Bytes.UPCE

Barcodes.Bytes.Code128

Barcodes.Bytes.Code39

Barcodes.Bytes.PostNet

Barcodes.Bytes.Interleaved25

Barcodes.Bytes.Standard25

Barcodes.Image.UPCA

Barcodes.Image.UPCE

Barcodes.Image.Code128

Barcodes.Image.Code39

Barcodes.Image.PostNet

Barcodes.Image.Interleaved25

Barcodes.Image.Standard25

Barcodes.Base64.UPCA

Barcodes.Base64.UPCE

Barcodes.Base64.Code128

Barcodes.Base64.Code39

Barcodes.Base64.PostNet

Barcodes.Base64.Interleaved25

Barcodes.Base64.Standard25

# Fork
Forked from https://github.com/jordao76/nbarcodes
NBarCodes is a third party DLL that was decompliled and signed with a strong key name.
NBarCodes is licenced for commercial use and modification. See NBarCodesLicense.txt
