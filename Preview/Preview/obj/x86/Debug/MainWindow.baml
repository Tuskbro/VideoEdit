   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   	   R NAxInterop.TimelineAxLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullR>clr-namespace:AxTimelineAxLib;assembly=AxInterop.TimelineAxLibAxTimelineAxLib 5   	   B >Preview, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PreviewPreview 5	   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5
   
      Preview.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V	 RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes 	 5   	   Iwf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms 	 5   	   Gax>clr-namespace:AxTimelineAxLib;assembly=AxInterop.TimelineAxLib 	 5   	   !localclr-namespace:Preview 	 5	   	   7dragablz(clr-namespace:Dragablz;assembly=Dragablz 	 5
   
   -   5          � Title$  LightShotClip Editor��5   	   $	��450��6'   $	��800��64   ���#0D0D0D � WindowStartupLocation$ CenterScreen=�6�    � WindowState$ 	Maximized=�6�   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��1.8* �6   �� 5      $
��Auto �6   �� 5      $��1* �6   .+�5   
   o� $��0��6   $��24��6   $	��Top=�6(   .@�5      m� $
��File��6   .@�5      m� -   5        $
��Open��5   )   $
��Open��6   65   m� 5      -   5        $��
NewProject��5   0   $��New project��6   6C   m� 5      -   5        $
��Save��5   )   $
��Save��6   65   m� 5      -   5        $��Import��5   +   $��Import��6   69   m� 5      -   5        $��Export��5   +   $��Export��6   69   m� 5!      $
��Exit��6   5"      m� 5$      -   5        $
��Help��5$   &   $
��Help��6   5&      m� 5'      -   5        $��
OpenPlayer��5'      $��Open Player��6B   6Y   5(      � 5*   
   $��1��6    � ColumnDefinitions 5+      �� 5,      $��1* �6#   �� 5-      $
��Auto �6#   �� 5.      $��1* �6#   �� 5/      $
��Auto �6#   �� 50      $��2* �6#   $	��400��6.   .+�57      ]� $��0��6   .+�58      &   System.Windows.Controls.DataGrid  -	   5        $��FileList��58   ^   $	��Top=�6I      
IsReadOnly .    AutoGenerateColumns .     MaxColumnWidth$	 150Q�6�   $��Microsoft Sans Serif)�6�   $��14(�6�      Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      -
   5        Name��,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��5:   ;     5;      -   5        
Format��$	 Format��5;   =     5<      -   5        Size��$
	 Size��5<   ;     5=      -   5        Path��$
	 Path��5=   ;   5?      5B      ]� 5D      $��4��6   .+�5E      � $	��Top=�6   .+�5F      7  1System.Windows.Forms.Integration.WindowsFormsHost  $��Stretch=�6$   $	��200��6B   $��Stretch=�6O   
   Child.
 5G      %   System.Windows.Forms.PictureBox  -   5        
PictureBox��"   System.Windows.Forms.Control   Dock$
 Fill=�5G   9      SizeMode$ AutoSize=�6E   5I      �� 5J      
������  J� Opacity$ 0Q�66   5L      � 5N      $	��Top=�6   $	��400��6,   $��Center=�6;   $��40��6X   $	��Top=�6d   .+�5O      �� -   5        $��StopPriViewBtn��5O   :   $��Center=�6   $��	3,3,120,3q�6m   $	����6�   $��60��6�   $��25��6�   6�   �� 5P      -   5        $��PlayPriviewBtn��5P   :   $��Center=�6   $��3q�6m   $	����6x   $��60��6�   $��25��6�   6�   �� 5Q      -   5        $��PausePriviewBtn��5Q   :   $��Center=�6   $��	120,3,3,3q�6p   $	����6�   $��60��6�   $��25��6�   6�   5R      5U      �� 5V      
����� �$��1��61    �� ShowsPreview .  $��3��6V   $��Center=�5W   	   $��Stretch=�6&   �� 5X      
����� �$��3��6-    .  $��3��6R   $��Center=�5Y   	   $��Stretch=�6&   5\        Preview.ToolsBar  5^   
   -   5          Name$ Tools��5^   &   $��2��6   6&     5`   
   -   5        $	��wfh��5`      $��3��6&   .
 5a      '  !AxTimelineAxLib.AxTimelineControl  -   5        
axTimeLine��5a   7   5b      5d      5e      