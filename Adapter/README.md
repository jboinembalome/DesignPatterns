# Adapter Pattern#

Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.

In this example, let's imagine that the PdfComponent comes from an external DLL.
The IDocument interface will adapt the PdfComponent class to have another class that will use the same methods as our internal code.
This way, our code is less dependent on external code.