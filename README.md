# Raygui-CS

This is a port of `raygui` library. Basically a direct translation of from the original `raygui.h` from C to C#, plus some modification.

Modification was made to reduce memory usage and heap memory allocation.

Current plan: port Raygui 4.0

## Redesigned:

- [x] GuiButton
- [x] GuiLine
- [x] GuiGroupBox
- [x] GuiLabel
- [x] GuiTabBar
- [x] GuiScrollPanel
- [x] GuiWindowBox
- [x] GuiMessageBox
- [x] GuiToggle
- [x] GuiToggleGroup

## New Controls

- [ ] GuiToggleSlider
- [x] GuiColorPickerHSV
- [x] GuiColorPanelHSV

Ported RAYGUIAPI in Raygui 3.6:

- [x] GuiEnable
- [x] GuiDisable
- [x] GuiLock
- [x] GuiUnlock
- [x] GuiIsLocked
- [x] GuiFade
- [x] GuiSetState
- [x] GuiGetState
- [x] GuiGetFont
- [x] GuiSetFont
- [x] GuiSetStyle
- [x] GuiGetStyle
- [x] GuiDrawIcon
- [x] GuiLabel
- [x] GuiButton
- [x] GuiToggle
- [x] GuiToolTip
- [x] GuiToggleGroup
- [x] GuiTextBox (Have some bugs, may review later)
- [x] ConvertRGBtoHSV
- [x] ConvertHSVtoRGB
- [x] GetColor
- [x] GuiScrollBar
- [x] GuiWindowBox
- [x] GuiSlider
- [x] GuiSliderBar
- [x] GuiSliderPro
- [x] GuiProgressBar
- [x] GuiListView
- [x] GuiListViewEx
- [x] GuiMessageBox
- [x] GuiTextInputBox
- [x] GuiGrid
- [x] GuiCheckBox
- [x] GuiComboBox
- [x] GuiDropdownBox
- [x] GuiSpinner
- [x] GuiValueBox
- [x] GuiColorPicker
- [x] GuiColorPanel
- [x] GuiColorBarAlpha
- [x] GuiColorBarHue
- [x] GuiLoadStyleDefault
- [x] GuiEnableTooltip
- [x] GuiDisableTooltip
- [x] GuiSetTooltip
- [x] GuiGroupBox
- [x] GuiLine
- [x] GuiPanel
- [x] GuiTabBar
- [x] GuiLoadIcons
- [?] GuiScrollPanel
- [?] GuiLoadStyle
- [?] GuiLoadStyleFromMemory

Note: ? means require validation.

## Future Plan

- Port Dark Theme

- Catch up API with master branch of main `raygui`.