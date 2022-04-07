0406

#### `GetComponent`로 속성 변경시키기   
- `gameObject.GetComponent<가져올 컴퍼넌트>()`   
-  예시 : `gameObject.GetComponent<BoxCollider>().isTrigger = true;`   
       
- 가져올 컴퍼넌트에 해당 오브젝트가 가진 스크립트(클래스)를 가져올 수 있다.   

<br>

#### Instantiate 복제 함수   
- `Instantiate(복사해서 생성할 게임오브젝트, 그 오브젝트가 나올 위치, 회전);`   
- 예시 : `Instantiate(gameObject, transform.position, transform.rotation);`   

이 때 Instantiate은 인스턴트화를 의미한다.   

<br>

#### Destory 오브젝트 삭제하기   
- `Destroy(gameObject);` 
   
<br>

#### prefab 부품화   
- 오브젝트를 assets창에 끌어와 부품화 - 필요할 때만 사용가능   

<br>

#### Invoke 딜레이를 두고 실행시키기   
- `Invoke("함수명", 시간초);`   
- `Invoke("DestroyGameObject", 2f);`    
   
2초 뒤에 이 함수를 실행을 해라
