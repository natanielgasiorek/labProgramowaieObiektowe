   M S B A M L   `   `   `  ����  Sklep Zoologiczny"    Sklep_Zoologiczny.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v21.2, Version=21.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      c _DevExpress.Xpf.Ribbon.v21.2, Version=21.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxr4http://schemas.devexpress.com/winfx/2008/xaml/ribbon   5      <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5      f bDevExpress.Xpf.Grid.v21.2.Core, Version=21.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v21.2, Version=21.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   5      d	 `DevExpress.Xpf.Docking.v21.2, Version=21.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxdo5http://schemas.devexpress.com/winfx/2008/xaml/docking 	 5      j
 fDevExpress.Xpf.LayoutControl.v21.2, Version=21.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aFdxlc;http://schemas.devexpress.com/winfx/2008/xaml/layoutcontrol 
 6H   +DataBaseSklep_Zoologiczny.BazaDanych 
 6�     � Title$  
MainWindow��5
      $	��800��6   $
��1000��6%    � WindowStyle$
 None=�62   &   DevExpress.Xpf.Core.ThemedWindow   ShowBackButton . .��5      � .+�5   
   )  #DevExpress.Xpf.Ribbon.RibbonControl     RibbonStyle$ 
Office2019=�6   $	��153��65      ShowApplicationButton .     Items. 5      5  /DevExpress.Xpf.Ribbon.RibbonDefaultPageCategory  2  ,DevExpress.Xpf.Ribbon.RibbonPageCategoryBase   Pages. 5      &   DevExpress.Xpf.Ribbon.RibbonPage  -   5          Name$ Produkty��5   !      Caption)  #DevExpress.Xpf.Core.ObjectConverter$ Produkty 63   	   Groups.	 5      +  %DevExpress.Xpf.Ribbon.RibbonPageGroup  
   Caption$
  ��6*      Items. 5      '  !DevExpress.Xpf.Bars.BarButtonItem  -   5          Name$ Dodaj_produkt��5   ,   !	  DevExpress.Xpf.Bars.BarItem 	  Content$ Dodaj produkt 6C    	  RibbonStyle$ Large=�6�    	  Glyph 6[   *
  $DevExpress.Xpf.Core.DXImageExtension
  */-SvgImages/Icon Builder/Actions_AddCircled.svg+6�   5        5      $
  ��6*   . 5        -   5        $ Edytuj_produkt��5   ,   $ Edytuj produkt 6D   $ Large=�6�    6]   
  *)'SvgImages/Icon Builder/Actions_Edit.svg+6�   5        5      $
  ��6*   . 5        -   5        $ Usuń_produkt��5   ,   $ Usuń produkt 6B   $ Large=�6�    6Y   
  *20SvgImages/Icon Builder/Actions_DeleteCircled.svg+6�   5        5      $
  ��6*   . 5        -   5        $ Odśwież_produkt��5   ,   $ Odśwież produkt 6E   $ Large=�6�    6_   
  *.,SvgImages/Outlook Inspired/PaymentRefund.svg+6�   5      5        5      -   5        $ 	Kategorie��5   !   $ 	Kategorie 64   .	 5         $
  ��6*   . 5!        -   5        $ Dodaj_kategorie��5!   ,   $ Dodaj kategorie 6E   $ Large=�6�    6_   
  */-SvgImages/Icon Builder/Actions_AddCircled.svg+6�   5"        5#      $
  ��6*   . 5$        -   5        $ Edytuj_kategorie��5$   ,   $ Edytuj kategorie 6F   $ Large=�6�    6a   
  *)'SvgImages/Icon Builder/Actions_Edit.svg+6�   5%        5&      $
  ��6*   . 5'        -	   5        $ Usuń_kategorie��5'   ,   $ Usuń kategorie 6D   $ Large=�6�    6]   
  *20SvgImages/Icon Builder/Actions_DeleteCircled.svg+6�   5(        5)      $
  ��6*   . 5*        -
   5        $ Odśwież_kategorie��5*   ,   $ Odśwież kategorie 6G   $ Large=�6�    6c   
  *.,SvgImages/Outlook Inspired/PaymentRefund.svg+6�   5+      5,        5.      -   5        $ Podkategorie��5.   !   $ Podkategorie 67   .	 5/        $
  ��6*   . 50        -   5        $ Dodaj_podkategorie��50   ,   $ Dodaj podkategorie 6H   $ Large=�6�    6e   
  */-SvgImages/Icon Builder/Actions_AddCircled.svg+6�   51        52      $
  ��6*   . 53        -   5        $ Edytuj_podkategorie��53   ,   $ Edytuj podkategorie 6I   $ Large=�6�    6g   
  *)'SvgImages/Icon Builder/Actions_Edit.svg+6�   54        55      $
  ��6*   . 56        -   5        $ Usuń_podkategorie��56   ,   $ Usuń podkategorie 6G   $ Large=�6�    6c   
  *20SvgImages/Icon Builder/Actions_DeleteCircled.svg+6�   57        58      $
  ��6*   . 59        -   5        $ Odśwież_podkategorie��59   ,   $ Odśwież podkategorie 6J   $ Large=�6�    6i   
  *.,SvgImages/Outlook Inspired/PaymentRefund.svg+6�   5:      5;        5=      -   5        $ 
Producenci��5=   !   $ 
Producenci 65   .	 5>        $
  ��6*   . 5?        -   5        $ Dodaj_producenta��5?   ,   $ Dodaj producenta 6F   $ Large=�6�    6a   
  */-SvgImages/Icon Builder/Actions_AddCircled.svg+6�   5@        5A      $
  ��6*   . 5B        -   5        $ Edytuj_producenta��5B   ,   $ Edytuj producenta 6G   $ Large=�6�    6c   
  *)'SvgImages/Icon Builder/Actions_Edit.svg+6�   5C        5D      $
  ��6*   . 5E        -   5        $ Usun_producenta��5E   ,   $ Usuń producenta 6E   $ Large=�6�    6_   
  *20SvgImages/Icon Builder/Actions_DeleteCircled.svg+6�   5F        5G      $
  ��6*   . 5H        -   5        $ Odśwież_producenta��5H   ,   $ Odśwież producenta 6H   $ Large=�6�    6e   
  *.,SvgImages/Outlook Inspired/PaymentRefund.svg+6�   5I      5J      5K      5L      . 	 (DevExpress.Xpf.Docking.DockLayoutManager  5N   
   $��10,161,10,7q�6!      
LayoutRoot. 5O      ( 	 "DevExpress.Xpf.Docking.LayoutGroup  + 	 %DevExpress.Xpf.Docking.BaseLayoutItem   Caption$ 
LayoutRoot��6      Items. 5P           Orientation$ Vertical=�6#      Margin$ 0,23,0,0q�6:   . 5Q      ( 	 "DevExpress.Xpf.Docking.LayoutPanel  $ Produkty��6'   $ 	0,-23,0,0q�6:      
Background
 �����( 	 "DevExpress.Xpf.Docking.ContentItem   Content. 5R      0 
 *DevExpress.Xpf.LayoutControl.LayoutControl  ���	#FF484848.+�5S      %  DevExpress.Xpf.Grid.GridControl  -   5          Name$ GridControlProdukty��5S   .   )  #DevExpress.Xpf.Grid.DataControlBase   AutoGenerateColumns$ AddNew=�6K   #   EnableSmartColumnsGeneration .    View 5T   "   #  DevExpress.Xpf.Grid.TableView  5U   &   $��
0,-18,0,18q�64      Columns. 5W   "   $  DevExpress.Xpf.Grid.GridColumn  $  DevExpress.Xpf.Grid.BaseColumn   Header$ ID Produktu 61   $  DevExpress.Xpf.Grid.ColumnBase   	FieldName$ ID_Produktu��6F      IsSmart . 6^     5X   "   $ Nazwa produktu 61   $ Nazwa_produktu��6I    . 6d     5Y   "   $ ID Kategorii 61   $ ID_Kategorii��6G    . 6`     5Z   "   -   5          Name$ KolumnaKategoria��5Z   1   $ 	Kategoria 6K   $ 	Kategorie��6^    . 6t     5[   "   $ ID Podkategorii 61   $ ID_Podkategorii��6J    . 6f     5\   "   -   5        $ KolumnaPodkategoria��5\   1   $ Podkategoria 6N   $ Podkategorie��6d    . 6}     5]   "   $ ID Producenta 61   $ ID_Producenta��6H    . 6b     5^   "   -   5        $ KolumnaProducent��5^   1   $ 	Producent 6K   $ 
Producenci��6^    . 6u   5`      5b      5c        5d      . 5e        $ 	Kategorie��6+   . 5f        .+�5g   "     -   5        $ GridControlKategorie��5g   2   $ AddNew=�6P    .  5h   &     5i   *   . 5k   &     $ ID Kategorii 65   $ ID_Kategorii��6K    . 6d     5l   &   $ Nazwa kategorii 65   $ Nazwa_kategorii��6N    . 6j   5m   #   5n      5o        5p      $ Podkategorie��6+   . 5q        .+�5r   "     -   5        $ GridControlPodkategorie��5r   2   $ AddNew=�6S    . . 5t   &     $ ID Podkategorii 65   $ ID_Podkategorii��6N    . 6j     5u   &   $ Nazwa podkategorii 65   $ Nazwa_podkategorii��6Q    . 6p   5v   #   5w      5x        5y      $ 
Producenci��6+   . 5z        .+�5{   "     -   5        $ GridControlProducenci��5{   2   $ AddNew=�6Q    .  5|   &     5}   *   . 5   &     $ ID Producenta 65   $ ID_Producenta��6L    . 6f     5�   &   $ Nazwa producenta 65   $ Nazwa_producenta��6O    . 6l   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      