using System;

namespace Passbook.Generator.Fields
{
    /// <summary>
    /// Barcode format
    /// </summary>
    public enum BarcodeType
    {
		/// <summary>
		/// No barcode format
		/// </summary>
		None = 0,
		/// <summary>
		/// QRCode
		/// </summary>
		PKBarcodeFormatQR = 1,
		/// <summary>
		/// PDF-417
		/// </summary>
		PKBarcodeFormatPDF417,
		/// <summary>
		/// Aztec
		/// </summary>
		PKBarcodeFormatAztec,
		/// <summary>
		/// Text
		/// </summary>
		PKBarcodeFormatText,

		/// <summary>
		/// Code128
		/// do not use in "barcode", 
		/// can be used in "barcodes",
		/// requires at least a PKBarcodeFormatText fallback for apple watch
		/// </summary>
		PKBarcodeFormatCode128 = 128,
    } 
}
