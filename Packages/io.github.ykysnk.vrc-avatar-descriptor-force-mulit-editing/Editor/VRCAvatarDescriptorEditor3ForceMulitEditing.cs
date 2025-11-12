#if VRC_SDK_VRCSDK3
using UnityEditor;
using VRC.SDK3.Avatars.Components;

namespace io.github.ykysnk.VRCAvatarDescriptorForceMultiEditing.Editor;

[CustomEditor(typeof(VRCAvatarDescriptor))]
[CanEditMultipleObjects]
public class AvatarDescriptorEditor3 : UnityEditor.Editor
{
}
#endif