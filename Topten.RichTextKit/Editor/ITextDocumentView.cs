﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Topten.RichTextKit.Editor
{
    /// <summary>
    /// Interface implemented by views of a TextDocument
    /// </summary>
    public interface ITextDocumentView
    {
        /// <summary>
        /// Notifies that the document is about to change
        /// </summary>C:\Users\Brad\Projects\RichTextKit\Topten.RichTextKit\Editor\ITextDocumentView.cs
        /// <param name="view">The view initiating the change</param>
        void OnDocumentWillChange(ITextDocumentView view);

        /// <summary>
        /// Notifies a view that the document has changed and provides
        /// information about which parts of the document were changed.
        /// </summary>
        /// <param name="view">The view initiating the change</param>
        /// <param name="info">Information about the change</param>
        void OnDocumentChange(ITextDocumentView view, DocumentChangeInfo info);

        /// <summary>
        /// Notifies that the document has finished changing
        /// </summary>
        /// <param name="view">The view initiating the change</param>
        void OnDocumentDidChange(ITextDocumentView view);
    }
}
