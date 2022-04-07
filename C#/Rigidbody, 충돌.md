0407

## Rigidbody (강체)
오브젝트에 물리적인 연산을 부여

>옵션
- Mass : 질량
- Drag : 공기저항
- Angular Drag : 공기저항(회전)
- Use Gravity : true일 때 중력 적용
- Is Kinematic : true일 때 물리 영향 받지 않음(중력도)
- Interpolate : 얼마나 부드럽게 물리를 적용할지
- Collision Detection : 충돌검사를 얼마나 촘촘하게 할지
- Constraints : 포지션과 로테이션에 대한 잠금 (잠금된 축은 물리영향 받지 않음)


<br>

- rigidbody collider : rigidbody가 포함된 콜라이더(rigidbody o boxcollider o)
- static collider : rigidbody가 포함되지 않은 콜라이더(rigidbody x boxcollider o)
is trigger : 충돌x 범위로만 존재할 수 있게 하는 것 (ex. 힐장판)

<br>

## 충돌의 종류 
- collision 충돌
- trigger 충돌 

![](https://imagedelivery.net/v7-TZByhOiJbNM9RaUdzSA/7c9638f9-e53b-48f3-8250-989c0a585300/public)


<br><br>

## 충돌과 관련된 함수
- 트리거 충돌이 일어났을 때 실행하는 ***이벤트*** 함수 
``` cpp
private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " 트리거 충돌");
    }
```
- 콜리전 충돌이 일어났을 때 실행하는 ***이벤트*** 함수
```cpp
private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " 콜리전 충돌");
    }
 ```
<br>

- 그 외에 충돌 중, 충돌 끝 시점에 실행되는 함수(트리거 충돌 시 예시)
 `private void OnTriggerStay(Collider other)`
`private void OnTriggerExit(Collider other)`

<br>

- 충돌 후 오브젝트를 삭제하기(콜리전 충돌 시 예시 )
`Destroy(gameObject);` : 자기자신 없어짐
`Destroy(collision.gameObject);`  : 부딪힌 오브젝트 없어짐
`Destroy(collision);` : 부딪힌 물체의 _콜라이더만_ 없어짐

<br>

- tag를 이용해 특정 오브젝트만 골라서 삭제하기
```cpp
if (collision.gameObject.tag == "wall")
 { 
 collision.gameObject.GetComponent<wall>().ReduceDurability(1);
 }
```


tag가 wall인 경우에만 실행
`gameObject.GetComponent<wall>`에서  `wall`은 태그가 아니고 충돌한 object가 가지고 있는 스크립트(`ReduceDurability()`라는 함수를 포함한)이다.
        


<br>

- 특정 여러 오브젝트를 지정할 때
`if(coillision.gameObject<wall>()!=null)` 
wall 스크립트(클래스)가지고 있으면 실행
