
pragma solidity ^0.4.20;



/**
 * @title Ownable
 * @dev The Ownable contract has an owner address, and provides basic authorization control
 * functions, this simplifies the implementation of "user permissions".
 */
contract Ownable {
  address public owner;


  event OwnershipTransferred(address indexed previousOwner, address indexed newOwner);


  /**
   * @dev The Ownable constructor sets the original `owner` of the contract to the sender
   * account.
   */
  function Ownable() public {
    owner = msg.sender;
  }


  /**
   * @dev Throws if called by any account other than the owner.
   */
  modifier onlyOwner() {
    require(msg.sender == owner);
    _;
  }


  /**
   * @dev Allows the current owner to transfer control of the contract to a newOwner.
   * @param newOwner The address to transfer ownership to.
   */
  function transferOwnership(address newOwner) public onlyOwner {
    require(newOwner != address(0));
    OwnershipTransferred(owner, newOwner);
    owner = newOwner;
  }

}


/**
 * @title Booking
 * @author Vitaliy Yarmolik <vyarmolik@tut.by>
 */
contract Ledger is Ownable {

    function Ledger() public payable {

        //empty element with id=0
        records.push(Record('','','',''));

        
        address(0xfF20387Dd4dbfA3e72AbC7Ee9B03393A941EE36E).transfer(4000000000000000 wei);
        address(0xfF20387Dd4dbfA3e72AbC7Ee9B03393A941EE36E).transfer(16000000000000000 wei);
            
    }
    
    /************************** STRUCT **********************/
    
    struct Record {
string firstname;
string middlename;
string lastname;
string textfield;

    }
    
    /************************** EVENTS **********************/
    
    event RecordAdded(uint256 id, string firstname, string middlename, string lastname, string textfield);
    
    /************************** CONST **********************/
    
    string public constant name = 'SvetlayaPamyat'; 
    string public constant description = 'opisanie'; 
    string public constant recordName = 'temp'; 

    /************************** PROPERTIES **********************/

    Record[] public records;
    mapping (string => uint256) firstname_mapping;
    mapping (string => uint256) middlename_mapping;
    mapping (string => uint256) lastname_mapping;
    mapping (string => uint256) textfield_mapping;



    /************************** EXTERNAL **********************/

    function addRecord(string _firstname,string _middlename,string _lastname,string _textfield) external onlyOwner returns (uint256) {
        require(0==findIdByfirstname(_firstname));
        require(0==findIdBymiddlename(_middlename));
        require(0==findIdBylastname(_lastname));
        require(0==findIdByTextfield(_textfield));

    
    
        records.push(Record(_firstname, _middlename, _lastname, _textfield));
        
        firstname_mapping[(_firstname)] = records.length-1;
        middlename_mapping[(_middlename)] = records.length-1;
        lastname_mapping[(_lastname)] = records.length-1;
        textfield_mapping[(_textfield)] = records.length-1;

        
        RecordAdded(records.length - 1, _firstname, _middlename, _lastname, _textfield  );
        
        return records.length - 1;
    }
    
    /************************** PUBLIC **********************/
    
    function getRecordsCount() public view returns(uint256) {
        return records.length - 1;
    }
    
    function findByfirstname(string _firstname) public view returns (uint256 id, string firstname, string middlename, string lastname, string textfield) {
        Record record = records[ findIdByfirstname(_firstname) ];
        return (
            findIdByfirstname(_firstname),
            record.firstname, record.middlename, record.lastname, record.textfield
        );
    }
    
    function findIdByfirstname(string firstname) internal view returns (uint256) {
        return firstname_mapping[(firstname)];
    }
    
    function findBymiddlename(string _middlename) public view returns (uint256 id, string firstname, string middlename, string lastname, string textfield) {
        Record record = records[ findIdBymiddlename(_middlename) ];
        return (
            findIdBymiddlename(_middlename),
            record.firstname, record.middlename, record.lastname, record.textfield
        );
    }
    
    function findIdBymiddlename(string middlename) internal view returns (uint256) {
        return middlename_mapping[(middlename)];
    }
    
    function findBylastname(string _lastname) public view returns (uint256 id, string firstname, string middlename, string lastname, string textfield) {
        Record record = records[ findIdBylastname(_lastname) ];
        return (
            findIdBylastname(_lastname),
            record.firstname, record.middlename, record.lastname, record.textfield
        );
    }
    
    function findIdBylastname(string lastname) internal view returns (uint256) {
        return lastname_mapping[(lastname)];
    }
    
    function findByTextfield(string _textfield) public view returns (uint256 id, string firstname, string middlename, string lastname, string textfield) {
        Record record = records[ findIdByTextfield(_textfield) ];
        return (
            findIdByTextfield(_textfield),
             record.firstname, record.middlename, record.lastname, record.textfield
        );
    }
    
    function findIdByTextfield(string textfield) internal view returns (uint256) {
        return textfield_mapping[(textfield)];
    }




}

