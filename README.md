# Roblox Style Camera for Unity

Unity Editor의 Scene View에 Roblox Studio 스타일의 직관적인 카메라 컨트롤을 추가하는 에디터 확장 도구입니다.

![Unity Version](https://img.shields.io/badge/Unity-2019.4%2B-blue)
![License](https://img.shields.io/badge/license-MIT-green)

## ✨ 특징

- 🎮 **Roblox Studio 스타일 조작**: 익숙한 WASD 키보드 컨트롤
- 🖱️ **마우스 회전**: 우클릭 드래그로 자유로운 시점 회전
- ⚡ **Shift 가속**: 빠른 이동을 위한 속도 부스트
- 🎯 **정밀 제어**: 실시간으로 조정 가능한 모든 속도 설정
- 💾 **세션 유지**: 설정값이 자동 저장됨
- 🔧 **설정 불필요**: 설치 즉시 자동 활성화

## 🎮 조작법

| 키/마우스 | 동작 |
|---------|------|
| **W** | 전진 |
| **S** | 후진 |
| **A** | 왼쪽으로 이동 |
| **D** | 오른쪽으로 이동 |
| **E** | 위로 이동 |
| **Q** | 아래로 이동 |
| **Shift** | 이동 속도 증가 (누르고 있는 동안) |
| **우클릭 + 드래그** | 카메라 회전 |
| **마우스 휠** | 줌 인/아웃 |

## 📦 설치 방법

### 방법 1: Unity Package Manager (권장)

1. Unity 프로젝트를 엽니다
2. `Window > Package Manager` 메뉴를 엽니다
3. 좌측 상단의 `+` 버튼 클릭
4. `Add package from git URL` 선택
5. 다음 URL을 입력:
   ```
   https://github.com/mn556112/roblox-camera-unity.git
   ```

### 방법 2: 직접 다운로드

1. 이 저장소를 다운로드하거나 클론합니다:
   ```bash
   git clone https://github.com/mn556112/roblox-camera-unity.git
   ```

2. `RobloxSceneCamera.cs` 파일을 Unity 프로젝트의 `Assets/Editor` 폴더에 복사합니다
   - `Editor` 폴더가 없다면 생성하세요

3. Unity가 자동으로 스크립트를 컴파일합니다

4. 완료! Scene View에서 바로 사용할 수 있습니다

## ⚙️ 설정

설정 창 열기: `Window > Roblox Camera Settings`

### 조정 가능한 설정값

- **Move Speed**: 기본 이동 속도 (기본값: 0.1)
- **Shift Multiplier**: Shift 키를 눌렀을 때 속도 배율 (기본값: 2.0)
- **Rotate Speed**: 마우스 회전 감도 (기본값: 0.15)
- **Zoom Speed**: 마우스 휠 줌 속도 (기본값: 0.5)

모든 설정은 실시간으로 적용되며 자동으로 저장됩니다.

### 기본값으로 리셋

설정 창 하단의 **Reset to Default** 버튼을 클릭하세요.

## 🔧 요구 사항

- Unity 2019.4 이상
- 모든 플랫폼 지원

## 📝 사용 예시

```csharp
// 이 도구는 자동으로 활성화되므로 추가 코드가 필요 없습니다!
// Scene View에서 바로 WASD 키와 마우스를 사용하세요.
```

## 🐛 문제 해결

### 카메라가 작동하지 않아요
- Scene View 창이 포커스되어 있는지 확인하세요
- Play Mode가 아닌지 확인하세요

### 이동 속도가 너무 빠르거나 느려요
- `Window > Roblox Camera Settings`에서 **Move Speed** 슬라이더를 조정하세요

### 마우스 회전이 너무 민감해요
- 설정 창에서 **Rotate Speed** 값을 낮춰보세요

### 설정을 초기화하고 싶어요
- 설정 창의 **Reset to Default** 버튼을 사용하세요

## 📄 라이선스

이 프로젝트는 MIT 라이선스 하에 배포됩니다.

## 🙏

Roblox Studio의 직관적인 카메라 컨트롤에서 영감을 받았습니다.

---
