using UnityEngine;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
	public class InputEventManager : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool dash;
		public bool attack;
		public bool reflect;
		public bool pause;

		[Header("Movement Settings")]
		public bool analogMovement;

		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
		public void OnMove(InputValue value)
		{
			MoveInput(value.Get<Vector2>());
		}

		public void OnLook(InputValue value)
		{
			if(cursorInputForLook)
			{
				LookInput(value.Get<Vector2>());
			}
		}

		public void OnJump(InputValue value)
		{
			JumpInput(value.isPressed);
		}

		public void OnDash(InputValue value)
		{
			DashInput(value.isPressed);
		}

		public void OnAttack(InputValue value)
		{
			AttackInput(value.isPressed);
		}

		public void OnReflect(InputValue value)
		{
			ReflectInput(value.isPressed);
		}

		public void OnPause(InputValue value)
        {
			PauseInput(value.isPressed);
        }
#endif


		public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;

			//Debug.Log("Move Input");
		} 

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;

			//Debug.Log("Look Input");
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;

			//Debug.Log("Jump Input");
		}

		public void DashInput(bool newDashState)
		{
			dash = newDashState;

			//Debug.Log("Dash Input");
		}

		public void AttackInput(bool newAttackState)
        {
			attack = newAttackState;

			//Debug.Log("Attack Input");
		}

		public void ReflectInput(bool newReflectState)
		{
			reflect = newReflectState;

			//Debug.Log("Reflect Input");
		}

		public void PauseInput(bool newPauseState)
        {
			pause = newPauseState;

			//Debug.Log("Pause Input");
		}

		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}
	}
	
}