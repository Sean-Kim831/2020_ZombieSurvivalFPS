# ZombieSurvivalFPS

## 소개

**제목**: 좀비(바이러스)의 위협으로부터 벗어나 백신을 얻으면 승리하는 1인칭 FPS 게임

**플랫폼**: 유니티 (웹)

**기술스택**: C#, Unity

**깃허브 주소**: [Computer Graphics Project](https://github.com/Sean-Kim831/2020_ZombieSurvivalFPS)

## 프로젝트 동기

**착안 및 주제 요약**:  
- 코로나 이슈에 착안하여 백신을 얻는 컨셉에 관심을 가짐
- 단순히 백신을 얻는게 아니라 그 과정속에서 외부의 무언가로부터 위협받고 그 위협에 대항하고 맞서는 방식 착안
- FPS장르 선택, 좀비(바이러스)의 위협으로부터 벗어나 백신을 얻으면 승리하는 게임 개발

## 개발 기간(2020.11 - 2020.12)

## 구현 개요
- 플레이어, 플레이어 이동, 스폰 로직
- 좀비, 좀비 이동, 스폰 로직
- 백신, 백신 스폰
- 사운드, 파티클, 모델에셋, 게임 UI

## 조작법
- WASD : 플레이어 이동 컨트롤
- 마우스 이동 : 플레이어 시선 컨트롤 (에임 조작)
- 마우스 왼쪽 버튼 : 총 발사
- 마우스 오른쪽 버튼 클릭 유지 : 견착 사격
- WASD + LEFT SHIFT : 플레이어 달리기
- SPACEBAR : 플레이어 점프
- R : 장전
- T : 총 둘러보기
- E : 총 들기 / 집어넣기 
- F : 칼 공격 (모션1)
- Q : 칼 공격 (모션2)


## 프로젝트 진행 중 직면한 문제점

1. **좀비의 벽 뚫기**  
   - 문제 상황: 좀비가 맵 속 구조물과 Terrain지형을 인식하지 못하고 뚫고 지나감
   - 해결 방안: 좀비의 Nav mesh를 전체 맵, 디테일(건물, 구조물) 부분에 모두 Bake시킴으로써 해결

2. **좀비 칼 공격 시 무효**  
   - 문제 상황: 플레이어가 좀비와 밀착하여 칼 공격 동작 시 좀비가 반응하지 않음
   - 해결 방안: 좀비의 Collider와 플레이어의 Empty Object의 Collider거리 조절을 통해 해결

3. **플레이어 칼 공격 시 한번에 모든 좀비 제거**  
   - 문제 상황: 플레이어의 칼 공격 한번으로 한 마리 좀비가 아닌 다수의 좀비들이 반응함
   - 해결 방안: 칼 공격 동작에 딜레이를 줌으로써 개선

4. **플레이어 추적 오류**  
   - 문제 상황: 좀비가 플레이어의 위치를 인식하지 못하고 (표적인식X) 특정한 지역으로 모임
   - 해결 방안: Find함수 통한 target설정으로 해결

5. **게임 재시작 오류 해결**  
   - 문제 상황: 게임 오버 후 재시작시 F5키를 두번 눌러야 했음
   - 해결 방안: P dmg 스크립트 start함우세 bool 변수 end를 false로 함으로써 재시작시 end가 true가 된 채로 시작하는 것을 방지하여 해결
  
  
## 레퍼런스

**Resource** :

- 건물 
https://assetstore.unity.com/packages/3d/environments/abandoned-buildings-62875
- 트럭
https://assetstore.unity.com/packages/3d/vehicles/land/post-apocalyptic-truck-with-armor-45422
- 백신
https://assetstore.unity.com/packages/3d/dna-85031
- 나무
https://assetstore.unity.com/packages/3d/vegetation/trees/dream-forest-tree-105297
- 눈
https://assetstore.unity.com/packages/3d/environments/landscapes/snow-mountain-24690
- 전반적인 건물, 디테일
https://assetstore.unity.com/packages/3d/environments/industrial/rpg-fps-game-assets-for-pc-mobile-industrial-set-v2-0-86679#content
- 벙커
https://assetstore.unity.com/packages/3d/environments/historic/world-war-1-pack-74843#content
- 플레이어
https://assetstore.unity.com/packages/3d/props/weapons/low-poly-fps-pack-free-sample-144839
- 좀비
https://assetstore.unity.com/packages/3d/characters/humanoids/zombie-30232피
https://assetstore.unity.com/packages/vfx/particles/blood-gush-73426
- 하늘
https://assetstore.unity.com/packages/2d/textures-materials/sky/sky5x-one-6332
- 음향
Freesound.org
soundeffect-lab/sound/battle/
soundeffect-lab.info
/~~~~
- 그라운드
https://assetstore.unity.com/packages/2d/textures-materials/floors/yughues-free-ground-materials-13001

## 결론
**게임 개발 프로세스 경험** : 
게임 개발 과정 및 협업 프로세스 경험

**오류 최적화 및 디버깅 능력** : 
게임 로직 오류와 게임 속도 최적화를 통해 최적화 및 디버깅 능력 향상
