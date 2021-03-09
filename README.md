# How to style the MasterDetailView expander cell and icon in WPF DataGrid (SfDataGrid)?
## About the sample

This example illustrates how to style the MasterDetailView expander cell and icon in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

[WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) alloes you to change the style of expander cell and icon using [DetailsViewDataGrid](http://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.DetailsViewDataGrid.html). You can change the expander cell border color by overriding the [GridDetailsViewExpanderCell](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.GridDetailsViewExpanderCell.html),[GridDetailsViewIndentCell](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.GridDetailsViewIndentCell.html) and [GridHeaderIndentCell](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.GridHeaderIndentCell.html) cells and change the BorderBrush property. 

You can also change the `DetailsViewDataGrid` expander icon by change the Path property of [GridDetailsViewExpanderCell](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.GridDetailsViewExpanderCell.html).

```XAML
<Window.Resources>
    <Style TargetType="syncfusion:GridHeaderIndentCell">
        <Setter Property="BorderBrush" Value="Red"/>
    </Style>
    <Style TargetType="syncfusion:GridDetailsViewIndentCell">
        <Setter Property="BorderBrush" Value="Red"/>
    </Style>
    <Style TargetType="syncfusion:GridDetailsViewExpanderCell">
        <Setter Property="Foreground" Value="#FF4D4D4D" />
        <Setter Property="BorderBrush" Value="Red" />
        <Setter Property="BorderThickness" Value="0,0,1,1" />
        <Setter Property="FontSize" Value="12" />
        <Setter Property="FocusVisualStyle" Value="{x:Null}" />
        <Setter Property="IsTabStop" Value="False" />
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="syncfusion:GridDetailsViewExpanderCell">
                    <Border Background="Transparent"
                        BorderBrush="{TemplateBinding BorderBrush}"
                        BorderThickness="{TemplateBinding BorderThickness}"
                        Padding="{TemplateBinding Padding}">
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="ExpansionStates">
                                <VisualState x:Name="Expanded">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="PART_CollapseCellPath" Storyboard.TargetProperty="(FrameworkElement.Visibility)">
                                            <DiscreteObjectKeyFrame Value="{x:Static Visibility.Collapsed}" KeyTime="0:0:0"/>

                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="PART_ExpanderCellPath" Storyboard.TargetProperty="(FrameworkElement.Visibility)">
                                            <DiscreteObjectKeyFrame Value="{x:Static Visibility.Visible}" KeyTime="0:0:0" />

                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                                <VisualState x:Name="Collapsed">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="PART_CollapseCellPath" Storyboard.TargetProperty="(FrameworkElement.Visibility)">
                                            <DiscreteObjectKeyFrame Value="{x:Static Visibility.Visible}" KeyTime="0:0:0"/>

                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="PART_ExpanderCellPath" Storyboard.TargetProperty="(FrameworkElement.Visibility)">
                                            <DiscreteObjectKeyFrame Value="{x:Static Visibility.Collapsed}" KeyTime="0:0:0"/>
                                        </ObjectAnimationUsingKeyFrames>

                                    </Storyboard>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateManager.VisualStateGroups>
                        <Grid Background="{TemplateBinding Background}" Visibility="{TemplateBinding ExpanderIconVisibility}" Margin="{TemplateBinding Padding}">
                            <Path Margin="7" x:Name="PART_CollapseCellPath"
                          Width="{TemplateBinding Width}"
                          Height="{TemplateBinding Height}"
                          HorizontalAlignment="Center"
                          VerticalAlignment="Center"
                          Data="F1M1464.78,374.21C1466.31,374.21,1466.94,375.538,1466.17,376.861L1435.89,429.439C1435.12,430.759,1433.87,430.823,1433.11,429.5L1402.82,376.827C1402.06,375.507,1402.69,374.21,1404.21,374.21L1464.78,374.21"
                          Fill="{TemplateBinding Foreground}"
                          SnapsToDevicePixels="True"
                          Stretch="Fill"
                          Stroke="{TemplateBinding Foreground}"
                          UseLayoutRounding="False">
                                <Path.RenderTransform>
                                    <TransformGroup>
                                        <TransformGroup.Children>
                                            <RotateTransform Angle="270" CenterX="4" CenterY="4" />
                                        </TransformGroup.Children>
                                    </TransformGroup>
                                </Path.RenderTransform>
                            </Path>
                            <Path x:Name="PART_ExpanderCellPath" Margin="7"
                          Width="{TemplateBinding Width}"
                          Height="{TemplateBinding Height}"
                          HorizontalAlignment="Center"
                          VerticalAlignment="Center"
                          Data="F1M1464.78,374.21C1466.31,374.21,1466.94,375.538,1466.17,376.861L1435.89,429.439C1435.12,430.759,1433.87,430.823,1433.11,429.5L1402.82,376.827C1402.06,375.507,1402.69,374.21,1404.21,374.21L1464.78,374.21"
                          Fill="{TemplateBinding Foreground}"
                          SnapsToDevicePixels="True"
                          Stretch="Fill"
                          Visibility="Collapsed"        
                          Stroke="{TemplateBinding Foreground}"
                          UseLayoutRounding="False">
                                <Path.RenderTransform>
                                    <TransformGroup>
                                        <TransformGroup.Children>
                                            <RotateTransform Angle="0" CenterX="4" CenterY="4" />
                                        </TransformGroup.Children>
                                    </TransformGroup>
                                </Path.RenderTransform>
                            </Path>
                        </Grid>
                    </Border>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>```

## Requirements to run the demo
Visual Studio 2015 and above versions