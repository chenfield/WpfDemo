   M S B A M L   `   `   `  ����  WpfDemoMain    WpfDemoMain.Shell   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&regionshttp://prismlibrary.com/  5   	   ?dxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm  5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5   	   $	��600��5   	   $	��450��5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title 5
   	   �� *
AppTitle+.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   !  Prism.Regions.RegionManager   
RegionName$ 	TopRegion��6&   6U   �� 5   
   $��1��6   $ 
MainRegion��6&   6V   �� 5   
   $��2��6   $ 	BarRegion��6&   5      5      5      