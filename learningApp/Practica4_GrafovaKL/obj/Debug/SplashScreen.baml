   M S B A M L   `   `   `  ????N  JPractica4_GrafovaKL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Practica4_GrafovaKLPractica4_GrafovaKL  5   	   &     Practica4_GrafovaKL.SplashScreen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Practica4_GrafovaKL     5   	     ? 
ResizeMode$  NoResize=?5   	    ? WindowStyle$
 None=?5	   	    ? WindowStartupLocation$ CenterScreen=?5
   	    ? Title$F @Обучающее приложение на тему Право??5   	   $	??460??64   $	??650??6A    ? 	Resources 5       
  Cancel??%A   &	        ?? 5   
   $??icons\cross-icon.png??6   5      5      .??5      ? ???#5A5A5A.+?5   
   ?? .+?5      ?? -   5        $??30??5      $??30??6    $
??Left=?6,    ?? Left$	 610??6G   $??Center=?6Y   
?????? 
??????   MyButtonStyle#??[ 5      .??5      C?  C? ResourceKey$ Cancel??6"   5      ?? 5      ???#FFB546 ?? TextAlignment$ Center=?6.   $??34(?6E   $??Inter)?6S   $??	ExtraBold"?6f   $	 158??6}   
 ?? Top$ 69??6?   ОБЩЕСТВОЗНАНИЕ	 J? Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   	Direction$	
 270Q?6'      
BlurRadius$ 5Q?67   5       5#      ?? 5$      ???#FFB546$ Center=?6.   $??30(?6E   $??Inter)?6S   $
??Bold"?6f   $	 235??6x   $	 110??6?   Тема: Право	 5&        5'      $	
 270Q?6'   $ 5Q?67   5)      5+      ?? 5,      -   5        $	??170??5,      $	??170??6#   $
?? ▶??6/   #??[ 6=   ???#FFB546$??68(?5-   '   $??	ExtraBold"?65   $??Center=?5/      $??Center=?6-   ???#060606
???   ?$??Center=?50   ;   $??Center=?51      $	 240??64   $	 160??6F    J? RenderTransformOrigin$ 0.5,0.5&?52      z?56      ?? 57       ?? ScaleX$ .7Q?6%    ?? ScaleY$ .7Q?61    ? Triggers 59      :? 5:       :? RoutedEvent$ 
MouseEnter??6#   .[?5;      ?? .??5<      ?? .??5=   "   W?  ?? TargetProperty$ RenderTransform.ScaleX?62   	 W? To$ 1X?6e    g? Duration$ 0:0:.4D?6l    W? EasingFunction 5>   &   0  *System.Windows.Media.Animation.QuarticEase  5?   *   5A   #   W? 5B   "   $ RenderTransform.ScaleY?62   $ 1X?6e   $ 0:0:.4D?6l    5C   &     5D   *   5F   #   5G      5H      5J      :? 5K      $ Button.MouseLeave??6#   .[?5L      ?? .??5M      ?? .??5N   "   W? $ RenderTransform.ScaleX?63   $ 0:0:.3D?6f   W? 5O   "   $ RenderTransform.ScaleY?63   $ 0:0:.3D?6g   5P      5Q      5R      	 5U        5V         ShadowDepth$ 10Q?6'      Opacity$	 0.5Q?68   $ 15Q?6F   $	
 270Q?5W   #   5Y       5[       ?? 
TargetType ?? Property ?? Value??%`   '??       ?? 5\      " ??6   .?5]      ??  ?@??CornerRadius$	 100??69   5^      5_      5`      ?? 5a      ???#D4D4D4$ Center=?6.   $??20(?6E   $??Inter)?5b      $
??Bold"?6(   $??205,392,0,10q?6:   )'Графова Ксения 2022 год	 5d        5e      $	
 270Q?6'   $ 10Q?67   $ 4Q?6G   $	 0.3Q?6W   5g      5i      5j      5m      5p      