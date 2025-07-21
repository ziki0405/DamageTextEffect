# DamageTextEffect
RPG游戏伤害飘字动画
一个轻量级、易用的 Unity 飘字动画脚本，适用于 RPG、动作、塔防等各类游戏的伤害/加血/提示数字弹出效果。

功能特点：
支持文字淡入-上升-淡出的经典飘字动画
可自定义上升距离、动画时长、淡入淡出速度
只需挂载到带有 TextMeshProUGUI 的 UI 预制体上即可使用
纯代码实现，无需依赖第三方插件

使用方法：
准备飘字Prefab
在 Canvas 下新建一个 TextMeshPro - Text（或 Text），设置好字体、颜色、大小等。
将其做成 Prefab，例如命名为 DamageTextPrefab。

挂载脚本：
将 DamageTextEffect.cs 脚本挂载到 DamageTextPrefab 上（与 TextMeshProUGUI 同级或父物体）。
在代码中实例化飘字
// 以 Canvas 为父对象实例化
   GameObject dmgText = Instantiate(damageTextPrefab, screenPos, Quaternion.identity, canvas.transform);
   var text = dmgText.GetComponentInChildren<TextMeshProUGUI>();
   if (text != null)
       text.text = amount.ToString();
   // DamageTextEffect 脚本会自动播放动画并销毁自己
脚本会自动播放动画并销毁自己

参数调整：
在 Inspector 面板可调整：
floatDistance：上升像素距离
duration：动画总时长
fadeInTime：淡入时长
fadeOutTime：淡出时长

效果演示：
文字会快速淡入，从下往上弹出一段距离，然后淡出并自动销毁。

依赖：
需要 Unity 的 TextMeshPro 组件。
