   M S B A M L   `   `   `  ????N  JPractica4_GrafovaKL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Practica4_GrafovaKLPractica4_GrafovaKL  5      %    Practica4_GrafovaKL.ProfilePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Practica4_GrafovaKL     5        N? Title$  ProfilePage??5	      .??5      ? ???#5A5A5A ? RowDefinitions 5   
   ?? 5      $
??2.6* ?6   ?? 5      $??2* ?6   ?? 5      $??2* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $??250,10q?5      $	??150??5      .+?5      ?? $??\icons\Begemotik5.png??6   5      ?? 5   
   $??1??6   .+?5      ?? $??40??6   $	??350??6!   $??0,0,0,0q?5       ?? CornerRadius$ 10??5      $??3q?5      ???#FFB546._?5      ?? -   5        $??Login??5      ???#FFB546$??40??6?   $	??350??6K   ???#633F09$
??Bold"?5   (   $??18(?5       ?? Padding$ 	15,5,10,5q?5       5&       J? Effect 5'      3  -System.Windows.Media.Effects.DropShadowEffect  5(         	Direction$	 270Q?6'      ShadowDepth$ 10Q?68      
BlurRadius$ 10Q?6I      Opacity$	 0.5Q?6Y   5*      5,      ?? 5-      $??40??6   $	??350??6!   $??0,20,0,0q?5.      $ 10??5/      $??3q?50      ???#FFB546._?52      ?? -   5        $??Email??52      ???#FFB546$??40??6?   $	??350??6K   ???#633F09$
??Bold"?53   (   $??18(?54      $ 	15,5,10,5q?55      5;       5<        5=      $	 270Q?6'   $ 10Q?68   $ 10Q?6I   $	 0.5Q?6Y   5?      5A      5E      ?? 5F   
   $??2??6   .+?5G      ?? $??70??6   $	??350??6!   $ 10??5I      $??3q?5J      
?????? ._?5L      ?? -   5        $??TestResultText??5L      
?????? $ 	15,5,10,5q?5N      $%??Результаты теста??5P      ???#D4D4D4$??32(?5S      $??	ExtraBold"?5T      $??Center=?5U       5X        5Y      $	 270Q?6+   $ 10Q?6<   $ 10Q?6M   $	 0.5Q?6]   5[      5]      5^      ?? 5_      $??40??6   $	??190??6!   $ 10??5a      $??3q?5b      ???#FFB546._?5d      ?? -   5        $??
TestResult??5d      ???#FFB546$??40??6D   ???#633F09$
??Bold"?5e   (   $??18(?5f      $ 	15,5,10,5q?5g      5m       5n        5o      $	 270Q?6'   $ 10Q?68   $ 10Q?6I   $	 0.5Q?6Y   5q      5s      5t      ?? 5u   
   $??4??6   .+?5v      ?? -   5        $
??Exit??5v      $	??150??6"   $??
Выйти??6.      SignInButtonStyle#??[  6?   ???#D4D4D4$??30(?5w   '   $
??Bold"?65   $??Center=?5y      
?????? 
?????? $??Center=?5{   E   $??Center=?5|      $??Center=?5}      	 J? RenderTransformOrigin$	 0.5,0.5&?5~      z?5      ?? 5?      
 ?? ScaleX$
 1Q?6%    ?? ScaleY$ 1Q?60    ? Triggers 5?      :? 5?       :? RoutedEvent$ 
MouseEnter??6#   .[?5?      ?? .??5?      ?? .??5?   "   W?  ?? TargetProperty$ RenderTransform.ScaleX?62   	 W? To$
 0.85X?6e    g? Duration$ 0:0:.3D?6o    W? EasingFunction 5?   &   0  *System.Windows.Media.Animation.QuarticEase  5?   *   5?   #   W? 5?   "   $ RenderTransform.ScaleY?62   $
 0.85X?6e   $ 0:0:.3D?6o    5?   &     5?   *   5?   #   5?      5?      5?      :? 5?      $ Button.MouseLeave??6#   .[?5?      ?? .??5?      ?? .??5?   "   W? $ RenderTransform.ScaleX?63   $ 0:0:.3D?6f   W? 5?   "   $ RenderTransform.ScaleY?63   $ 0:0:.3D?6g   5?      5?      5?       5?        5?      $ 10Q?6'   $	 0.5Q?68   $ 15Q?6F   $	 270Q?5?   #   5?      5?      5?      5?      5?      