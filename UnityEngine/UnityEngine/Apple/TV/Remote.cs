﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Apple.TV.Remote
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System.Runtime.CompilerServices;

namespace UnityEngine.Apple.TV
{
  /// <summary>
  ///   <para>A class for Apple TV remote input configuration.</para>
  /// </summary>
  public sealed class Remote
  {
    /// <summary>
    ///   <para>Configures how "Menu" button behaves on Apple TV Remote. If this property is set to true hitting "Menu" on Remote will exit to system home screen. When this property is false current application is responsible for handling "Menu" button. It is recommended to set this property to true on top level menus of your application.</para>
    /// </summary>
    public static extern bool allowExitToHome { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Configures if Apple TV Remote should autorotate all the inputs when Remote is being held in horizontal orientation. Default is false.</para>
    /// </summary>
    public static extern bool allowRemoteRotation { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Configures how touches are mapped to analog joystick axes in relative or absolute values. If set to true it will return +1 on Horizontal axis when very far right is being touched on Remote touch aread (and -1 when very left area is touched correspondingly). The same applies for Vertical axis too. When this property is set to false player should swipe instead of touching specific area of remote to generate Horizontal or Vertical input.</para>
    /// </summary>
    public static extern bool reportAbsoluteDpadValues { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///         <para>Disables Apple TV Remote touch propagation to Unity Input.touches API. Useful for 3rd party frameworks, which do not respect Touch.type == Indirect.
    /// Default is false.</para>
    ///       </summary>
    public static extern bool touchesEnabled { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }
  }
}
