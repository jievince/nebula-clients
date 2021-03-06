/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

namespace nebula.storage
{
  public enum ErrorCode
  {
    SUCCEEDED = 0,
    E_DISCONNECTED = -1,
    E_FAILED_TO_CONNECT = -2,
    E_RPC_FAILURE = -3,
    E_LEADER_CHANGED = -11,
    E_KEY_HAS_EXISTS = -12,
    E_SPACE_NOT_FOUND = -13,
    E_PART_NOT_FOUND = -14,
    E_KEY_NOT_FOUND = -15,
    E_CONSENSUS_ERROR = -16,
    E_DATA_TYPE_MISMATCH = -17,
    E_INVALID_FIELD_VALUE = -18,
    E_REBUILD_INDEX_FAILED = -19,
    E_INVALID_OPERATION = -20,
    E_NOT_NULLABLE = -21,
    E_FIELD_UNSET = -22,
    E_OUT_OF_RANGE = -23,
    E_ATOMIC_OP_FAILED = -24,
    E_EDGE_PROP_NOT_FOUND = -31,
    E_TAG_PROP_NOT_FOUND = -32,
    E_IMPROPER_DATA_TYPE = -33,
    E_EDGE_NOT_FOUND = -34,
    E_TAG_NOT_FOUND = -35,
    E_INVALID_SPACEVIDLEN = -36,
    E_INDEX_NOT_FOUND = -37,
    E_INVALID_FILTER = -41,
    E_INVALID_UPDATER = -42,
    E_INVALID_STORE = -43,
    E_INVALID_PEER = -44,
    E_RETRY_EXHAUSTED = -45,
    E_TRANSFER_LEADER_FAILED = -46,
    E_INVALID_STAT_TYPE = -47,
    E_INVALID_VID = -48,
    E_LOAD_META_FAILED = -51,
    E_FAILED_TO_CHECKPOINT = -60,
    E_CHECKPOINT_BLOCKED = -61,
    E_PARTIAL_RESULT = -71,
    E_FILTER_OUT = -81,
    E_INVALID_DATA = -82,
    E_INVALID_TASK_PARA = -90,
    E_USER_CANCEL = -99,
    E_UNKNOWN = -100,
  }
}
