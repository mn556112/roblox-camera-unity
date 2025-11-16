using UnityEditor;
using UnityEngine;
[InitializeOnLoad]
public static class RobloxSceneCamera
{
    static float moveSpeed = 0.1f;
    static float fastSpeedMultiplier = 2f;
    static float rotateSpeed = 0.15f;
    static float zoomSpeed = 0.5f;
    static bool keyW, keyA, keyS, keyD, keyE, keyQ, keyShift;
    static RobloxSceneCamera()
    {
        SceneView.duringSceneGui += OnSceneGUI;
    }
    [MenuItem("Window/Roblox Camera Settings")]
    static void ShowSettings()
    {
        RobloxCameraSettingsWindow.ShowWindow();
    }
    static void OnSceneGUI(SceneView scene)
    {
        Event e = Event.current;
        // 🔹 1. 키 입력 상태 업데이트
        if (e.type == EventType.KeyDown || e.type == EventType.KeyUp)
        {
            bool isDown = e.type == EventType.KeyDown;
            switch (e.keyCode)
            {
                case KeyCode.W: keyW = isDown; break;
                case KeyCode.A: keyA = isDown; break;
                case KeyCode.S: keyS = isDown; break;
                case KeyCode.D: keyD = isDown; break;
                case KeyCode.E: keyE = isDown; break;
                case KeyCode.Q: keyQ = isDown; break;
                case KeyCode.LeftShift:
                case KeyCode.RightShift:
                    keyShift = isDown; break;
            }
        }
        // 🔹 2. 마우스 오른쪽 드래그 회전
        if (e.type == EventType.MouseDrag && e.button == 1)
        {
            Vector2 delta = e.delta;
            Vector3 rot = scene.rotation.eulerAngles;
            rot.x += delta.y * rotateSpeed;
            rot.y += delta.x * rotateSpeed;
            scene.rotation = Quaternion.Euler(rot);
            e.Use();
        }
        // 🔹 3. WASD + EQ 지속 이동 (pivot 사용)
        if (e.type == EventType.Repaint || e.type == EventType.Layout)
        {
            Vector3 dir = Vector3.zero;
            if (keyW) dir += Vector3.forward;
            if (keyS) dir += Vector3.back;
            if (keyA) dir += Vector3.left;
            if (keyD) dir += Vector3.right;
            if (keyE) dir += Vector3.up;
            if (keyQ) dir += Vector3.down;
            float speed = moveSpeed * Time.deltaTime;
            if (keyShift) speed *= fastSpeedMultiplier;
            if (dir != Vector3.zero)
            {
                scene.pivot += scene.rotation * (dir * speed);
                scene.Repaint();
            }
        }
        // 🔹 4. 마우스 휠 전/후 이동
        if (e.type == EventType.ScrollWheel)
        {
            float scroll = -e.delta.y * zoomSpeed;
            scene.pivot += scene.rotation * Vector3.forward * scroll;
            e.Use();
            scene.Repaint();
        }
    }
    public class RobloxCameraSettingsWindow : EditorWindow
    {
        public static void ShowWindow()
        {
            GetWindow<RobloxCameraSettingsWindow>("Camera Settings");
        }
        void OnGUI()
        {
            GUILayout.Label("Roblox Camera Settings", EditorStyles.boldLabel);
            EditorGUILayout.Space();
            moveSpeed = EditorGUILayout.Slider("Move Speed", moveSpeed, 0.1f, 20f);
            fastSpeedMultiplier = EditorGUILayout.Slider("Shift Multiplier", fastSpeedMultiplier, 1f, 10f);
            rotateSpeed = EditorGUILayout.Slider("Rotate Speed", rotateSpeed, 0.01f, 1f);
            zoomSpeed = EditorGUILayout.Slider("Zoom Speed", zoomSpeed, 0.1f, 5f);
            EditorGUILayout.Space();
            if (GUILayout.Button("Reset to Default"))
            {
                moveSpeed = 3f;
                fastSpeedMultiplier = 2.5f;
                rotateSpeed = 0.15f;
                zoomSpeed = 0.5f;
            }
        }
    }
}